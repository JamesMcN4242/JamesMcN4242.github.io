using System.Globalization;
using System.Net;
using System.Text;
using System.Text.Json;

namespace PortfolioSite.Services;

public enum TextCodecOperation
{
    Base64Encode,
    Base64Decode,
    Base64UrlEncode,
    Base64UrlDecode,
    UrlEncode,
    UrlDecode,
    HtmlEncode,
    HtmlDecode,
    HexEncode,
    HexDecode,
    JsonStringEncode,
    JsonStringDecode
}

public static class UtilityTools
{
    private static readonly UTF8Encoding StrictUtf8 = new(false, true);

    public static string FormatJson(string input, bool indented)
    {
        using var document = JsonDocument.Parse(input);
        return JsonSerializer.Serialize(document.RootElement, new JsonSerializerOptions { WriteIndented = indented });
    }

    public static byte[] TextToBytes(string text) => StrictUtf8.GetBytes(text);

    // Data is treated as binary when it is not valid UTF-8 or contains control characters other than tab/newlines.
    public static string ToDisplayText(byte[] data, out bool isBinary)
    {
        if (TryGetText(data, out var text) && !text.Any(c => char.IsControl(c) && c is not ('\t' or '\n' or '\r')))
        {
            isBinary = false;
            return text;
        }

        isBinary = true;
        return Convert.ToHexString(data).ToLowerInvariant();
    }

    public static byte[] Transform(byte[] input, TextCodecOperation operation) => operation switch
    {
        TextCodecOperation.Base64Encode => Encoding.ASCII.GetBytes(Convert.ToBase64String(input)),
        TextCodecOperation.Base64Decode => DecodeBase64(RequireText(input), urlSafe: false),
        TextCodecOperation.Base64UrlEncode => Encoding.ASCII.GetBytes(Convert.ToBase64String(input).TrimEnd('=').Replace('+', '-').Replace('/', '_')),
        TextCodecOperation.Base64UrlDecode => DecodeBase64(RequireText(input), urlSafe: true),
        TextCodecOperation.UrlEncode => Encoding.ASCII.GetBytes(PercentEncode(input)),
        TextCodecOperation.UrlDecode => PercentDecode(RequireText(input)),
        TextCodecOperation.HtmlEncode => StrictUtf8.GetBytes(WebUtility.HtmlEncode(RequireText(input))),
        TextCodecOperation.HtmlDecode => StrictUtf8.GetBytes(WebUtility.HtmlDecode(RequireText(input))),
        TextCodecOperation.HexEncode => Encoding.ASCII.GetBytes(Convert.ToHexString(input).ToLowerInvariant()),
        TextCodecOperation.HexDecode => DecodeHex(RequireText(input)),
        TextCodecOperation.JsonStringEncode => StrictUtf8.GetBytes(JsonSerializer.Serialize(RequireText(input))),
        TextCodecOperation.JsonStringDecode => StrictUtf8.GetBytes(DecodeJsonString(RequireText(input))),
        _ => throw new ArgumentOutOfRangeException(nameof(operation))
    };

    private static bool TryGetText(byte[] data, out string text)
    {
        try
        {
            text = StrictUtf8.GetString(data);
            return true;
        }
        catch (DecoderFallbackException)
        {
            text = "";
            return false;
        }
    }

    private static string RequireText(byte[] data) => TryGetText(data, out var text)
        ? text
        : throw new FormatException("This step needs text input, but the previous step produced binary data (not valid UTF-8). To view binary data, use Hex encode or Base64 encode instead.");

    private static byte[] DecodeBase64(string input, bool urlSafe)
    {
        var compact = string.Concat(input.Where(c => !char.IsWhiteSpace(c)));
        var unpadded = compact.TrimEnd('=');
        var padding = compact.Length - unpadded.Length;
        var (extra1, extra2, name) = urlSafe ? ('-', '_', "Base64URL") : ('+', '/', "Base64");
        if (unpadded.Any(c => !char.IsAsciiLetterOrDigit(c) && c != extra1 && c != extra2) ||
            unpadded.Length % 4 == 1 || padding > 2 || (padding > 0 && compact.Length % 4 != 0))
        {
            var hint = !urlSafe && unpadded.Any(c => c is '-' or '_') ? " This looks like Base64URL; try Base64URL decode."
                : urlSafe && unpadded.Any(c => c is '+' or '/') ? " This looks like standard Base64; try Base64 decode."
                : "";
            throw new FormatException($"Invalid {name}. Use letters, digits, '{extra1}' and '{extra2}', with optional '=' padding.{hint}");
        }

        var standard = urlSafe ? unpadded.Replace('-', '+').Replace('_', '/') : unpadded;
        return Convert.FromBase64String(standard + new string('=', (4 - standard.Length % 4) % 4));
    }

    private static byte[] DecodeHex(string input)
    {
        try
        {
            return Convert.FromHexString(input);
        }
        catch (FormatException)
        {
            throw new FormatException("Invalid hex. Use an even number of hexadecimal digits with no spaces.");
        }
    }

    private static string PercentEncode(byte[] data)
    {
        var builder = new StringBuilder(data.Length * 3);
        foreach (var value in data)
        {
            var character = (char)value;
            if (char.IsAsciiLetterOrDigit(character) || character is '-' or '.' or '_' or '~')
                builder.Append(character);
            else
                builder.Append('%').Append(value.ToString("X2", CultureInfo.InvariantCulture));
        }

        return builder.ToString();
    }

    private static byte[] PercentDecode(string input)
    {
        var bytes = new List<byte>();
        var start = 0;
        for (var i = 0; i < input.Length; i++)
        {
            if (input[i] != '%')
                continue;

            bytes.AddRange(StrictUtf8.GetBytes(input[start..i]));
            if (i + 2 >= input.Length ||
                !byte.TryParse(input.AsSpan(i + 1, 2), NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture, out var value))
            {
                throw new FormatException("Each '%' must be followed by two hexadecimal digits.");
            }

            bytes.Add(value);
            i += 2;
            start = i + 1;
        }

        bytes.AddRange(StrictUtf8.GetBytes(input[start..]));
        return bytes.ToArray();
    }

    private static string DecodeJsonString(string input)
    {
        using var document = JsonDocument.Parse(input);
        if (document.RootElement.ValueKind != JsonValueKind.String)
            throw new FormatException("Enter a JSON string including its surrounding double quotes, not an object, array, number, or null.");

        try
        {
            return document.RootElement.GetString()!;
        }
        catch (InvalidOperationException exception)
        {
            throw new FormatException("The JSON string contains an invalid Unicode escape sequence.", exception);
        }
    }
}
