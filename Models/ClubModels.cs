namespace PortfolioSite.Models;

public sealed record BlogPost(
    string Slug,
    string Title,
    string Summary,
    IReadOnlyList<string> Paragraphs,
    string Category,
    string Author,
    DateTime PublishedOn,
    IReadOnlyList<string> Tags);

public sealed record MembershipFee(string Label, string Price, string Note);

public sealed record ScheduleSlot(string Day, string Time, string Venue, string Focus, string Notes);

public sealed record VenueInfo(string Name, string District, string Details, string Address, string Url);

public sealed record CoachProfile(string Name, string Role, string Focus, string Summary);

public sealed record LinkItem(string Label, string Url, string Description);

public sealed record LinkGroup(string Title, IReadOnlyList<LinkItem> Items);

public sealed record BoardRole(string Role, string Name);

public sealed record LeagueStanding(string League, string Team, int Points, int Rounds);

public sealed record ContactChannel(string Label, string Value, string Url, string Note);

public sealed record ClubFact(string Value, string Label);