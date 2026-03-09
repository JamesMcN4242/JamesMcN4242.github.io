using PortfolioSite.Models;

namespace PortfolioSite.Services;

public sealed class ClubContentService
{
    private readonly IReadOnlyList<ClubFact> _facts =
    [
        new("1969", "Vereinsgruendung"),
        new("rund 100", "Mitglieder"),
        new("24", "Staatsbuergerschaften"),
        new("5", "Liga-Teams")
    ];

    private readonly IReadOnlyList<MembershipFee> _membershipFees =
    [
        new("Erwachsene", "190 EUR", "209 EUR bei Zahlung nach dem 30. September"),
        new("Halbe Mitgliedschaft", "100 EUR", "Gueltig fuer Maerz bis August"),
        new("Reduziert", "120 EUR", "132 EUR nach dem 30. September, fuer Jugend, Studierende unter 27 und definierte Sozialtarife"),
        new("Foerdermitgliedschaft", "70 EUR", "Ohne aktiven Spielbetrieb"),
        new("Sommermitgliedschaft", "50 EUR", "Juli und August")
    ];

    private readonly IReadOnlyList<string> _membershipBenefits =
    [
        "Zahlreiche freie Spieltermine mit rund 13 bis 15 Stunden Hallenzeit pro Woche.",
        "Woechentliche Trainings mit erfahrenen Trainerinnen und Trainern fuer Liga, Nachwuchs und Technikaufbau.",
        "Training auch in den Sommermonaten, damit der Verein das ganze Jahr ueber aktiv bleibt.",
        "Klare Einstiegslogik ueber Spielstaerke, damit Schnuppernde im passenden Umfeld ankommen."
    ];

    private readonly IReadOnlyList<string> _joinSteps =
    [
        "Anfrage mit Alter, Geschlecht und Spielstaerke an das Vereinsteam senden.",
        "Nach Rueckmeldung einen passenden Schnupper- oder Trainingstermin abstimmen.",
        "Bei freien Kapazitaeten in die passende Trainings- oder Spielgruppe aufgenommen werden.",
        "Bei hoher Auslastung erfolgt die Aufnahme ueber die Warteliste, ausgenommen Nachwuchs und leistungsstarke Erwachsene."
    ];

    private readonly IReadOnlyList<ScheduleSlot> _seasonSchedule =
    [
        new("Montag", "19:15 bis 22:30", "FloHe", "Freies Spielen", "Teilweise mit Ligaspielen, wenn Heimrunden angesetzt sind."),
        new("Dienstag", "18:00 bis 19:00", "Medwedweg", "Jugendtraining", "Zwei Courts bleiben fuer freies Spielen verfuegbar."),
        new("Dienstag", "19:00 bis 21:00", "Medwedweg", "Freies Spielen", "Offen fuer Mitglieder aller Levels."),
        new("Dienstag", "20:00 bis 22:30", "HDB Liesing", "Freies Spielen", "Abendfenster fuer Spielpraxis in der Stammhalle."),
        new("Donnerstag", "20:00 bis 22:00", "Sportarena", "Allgemeines Training", "Einlass ab 19:30, zusaetzlich ein bis zwei Courts fuer freies Spielen."),
        new("Freitag", "20:00 bis 22:30", "HDB Liesing", "Liga-Training und Heimspiele", "Je nach Spieltag zwei bis drei Courts Training, dazu freies Spielen."),
        new("Freitag", "17:30 bis 22:30", "Hopsagasse", "WBV Freies Spielen", "Offenes Verbandsangebot, Anmeldung erforderlich.")
    ];

    private readonly IReadOnlyList<ScheduleSlot> _summerSchedule =
    [
        new("Montag", "19:15 bis 22:30", "FloHe", "Freies Spielen", "Sommerbetrieb vom 5. Juli bis 5. September 2026."),
        new("Dienstag", "20:00 bis 22:30", "HDB Liesing", "Liga-Training", "Bis 21:15 reserviert, parallel und danach freies Spielen."),
        new("Freitag", "20:00 bis 22:30", "HDB Liesing", "Liga-Training", "Vier Courts bis 21:15, danach offenes Spielen.")
    ];

    private readonly IReadOnlyList<VenueInfo> _venues =
    [
        new("HDB Liesing", "23. Bezirk", "Stammhalle mit regelmaessigem Liga- und Abendbetrieb", "Sporthalle im Haus der Begegnung Liesing, Wien", "http://www.urw-badminton.at/content/liesing"),
        new("FloHe", "11. Bezirk", "Rundhalle Simmering fuer freie Spieltermine und Heimrunden", "Florian-Hedorfer-Strasse 24, Wien", "https://www.wien.gv.at/freizeit/sportamt/sportstaetten/hallen/simmering.html"),
        new("Medwedweg", "11. Bezirk", "Jugendstandort mit anschliessendem freien Spiel", "Medwedweg 18, Eingang Buergerspitalwiese, Wien", "https://www.google.com/maps/place/Beachvolleyballfeld/@48.1823221,16.4125193,18.08z/data=!4m6!3m5!1s0x476da971ba91f4cb:0x26f84fb3ba46e8e!8m2!3d48.1822801!4d16.4129332!16s%2Fg%2F11h79xr69j"),
        new("Sportarena", "2. Bezirk", "Donnerstags Training mit zusaetzlichen freien Courts", "Sportarena, Wien", "https://www.google.com/maps/place//data=!4m2!3m1!1s0x476d072d914082cb:0x9756ded7c2cf39cd?sa=X&ved=1t:8290&ictx=111"),
        new("Hopsagasse", "20. Bezirk", "WBV offener Spieltermin fuer alle Wiener Vereine", "Hopsagasse 7, Wien", "https://spond.com/landing/group/GBYUW"),
        new("Alt-Erlaa", "23. Bezirk", "Turnier- und Meisterschaftsstandort im Sueden Wiens", "Rundhalle Alt-Erlaa, Wien", "https://www.google.com/maps/search/Alt+Erlaa+Sporthalle+Wien")
    ];

    private readonly IReadOnlyList<CoachProfile> _coaches =
    [
        new("Lalropuia \"RP\"", "Grundlagentrainer und Spielertrainer", "Herreneinzel und Mannschaft 1 bis 2", "Bundesligaspieler in St. Poelten, technisch praegend fuer die leistungsorientierte Vereinslinie."),
        new("Hanna Faist", "B-Trainerin", "Doppel, Mixed und Liga", "Stabilisiert den Erwachsenenbereich und begleitet Spitzenspielerinnen und Spitzenspieler im Doppel."),
        new("Gustav Andree", "Nationalspieler", "Aktuelle Technik und Spitzensportimpulse", "Bringt Input aus dem Leistungszentrum Graz in Camps und Schwerpunkttrainings nach Wien."),
        new("Marian Gratzer", "Nachwuchs- und Techniktrainer", "Grundlagentechnik und Jugend", "Leitet Technikaufbau und Jugendtraining mit klarer Struktur fuer Einsteiger und Nachwuchs."),
        new("Ray Chen", "Mannschaftskapitaen und Taktikcoach", "Ligaentwicklung und Matchpraxis", "Kennt die Leistungsbilder der Liga-Teams im Detail und setzt taktische Schwerpunkte."),
        new("Jordan McMahon", "Trainer und Jugendreferent", "Entwicklung, Coaching und Matchpraxis", "Verbindet internationale Erfahrung mit Wiener Nachwuchsarbeit und Trainerpraxis.")
    ];

    private readonly IReadOnlyList<string> _levelDescriptions =
    [
        "Anfaenger: Grundschlaege wurden noch nicht systematisch vermittelt.",
        "Leicht fortgeschritten: Clear, Drop, Smash und Drive sind bekannt, dazu erste Laufwege und Raumaufteilung.",
        "Fortgeschritten: Regelmaessiges badminton-spezifisches Training und erste Verbandsturniere gehoeren bereits dazu.",
        "Spitzenspieler: Mehrjaehrige Arbeit mit Trainerinnen und Trainern und Niveau in der ersten oder zweiten Landesliga oder darueber."
    ];

    private readonly IReadOnlyList<string> _trainingPrinciples =
    [
        "Der Verein ist offen fuer alle Spielstaerken, der Einstieg ist aber nicht zu jedem Zeitpunkt moeglich.",
        "Auch ohne festen Spielpartner findet man passende Trainings- und Matchpartner im Verein.",
        "Leitungsgefuehrte Kurse setzen eine Mitgliedschaft voraus.",
        "Nicht jeder Termin ist fuer jedes Level gedacht, freie Spieltermine bleiben aber offen fuer alle Alters- und Leistungsstufen."
    ];

    private readonly IReadOnlyList<string> _competitionNotes =
    [
        "Turniernennungen, die eine Vereinsfreigabe brauchen, werden zentral koordiniert und nach Ruecksprache bestaetigt.",
        "Fuer Spielerinnen und Spieler mit wenig Turniererfahrung eignen sich vor allem die B- und C-Kategorien der Wiener Verbandsturniere.",
        "Die Mannschaftsfuehrungen entscheiden, wer fuer eines der fuenf Liga-Teams zum Einsatz kommt.",
        "Die OeBV Ranglisten bilden die individuelle Punktewertung fuer Einzel, Doppel und Mixed ab und dienen als Standortbestimmung."
    ];

    private readonly IReadOnlyList<string> _competitionHighlights =
    [
        "12. Januar: URW Derby Team 2 gegen Team 3 in FloHe.",
        "16. Januar: Team 1 gegen WBH in Liesing.",
        "23. Januar: Team 2 gegen Simmering in Liesing.",
        "26. Januar: Team 3 gegen WBH in FloHe.",
        "13. Maerz: Landesliga-Heimspiel URW 1 gegen Union VRC 1 in Liesing."
    ];

    private readonly IReadOnlyList<LeagueStanding> _leagueTable =
    [
        new("1. Landesliga", "WAT Simmering 2", 24, 9),
        new("1. Landesliga", "WBH Wien 2", 23, 9),
        new("1. Landesliga", "Union VRC Badminton 2", 20, 9),
        new("1. Landesliga", "Union VRC Badminton 3", 15, 9),
        new("1. Landesliga", "URW Wien 1", 13, 9),
        new("1. Landesliga", "ASVOe Racketsport Voesendorf 1", 13, 9),
        new("2. Wiener Liga", "BC Wienerberg 1", 27, 9),
        new("2. Wiener Liga", "WBH Wien 3", 23, 9),
        new("2. Wiener Liga", "URW Wien 2", 23, 9),
        new("2. Wiener Liga", "WAT Simmering 3", 20, 9),
        new("2. Wiener Liga", "URW Wien 3", 12, 9),
        new("2. Wiener Liga", "FSPV Erste Bank 1", 3, 9),
        new("3. Wiener Liga", "Union VRC Badminton 4", 22, 8),
        new("3. Wiener Liga", "ASVOe Racketsport Voesendorf 2", 20, 7),
        new("3. Wiener Liga", "BC Wienerberg 2", 17, 7),
        new("3. Wiener Liga", "Union VRC Badminton 5", 10, 7),
        new("3. Wiener Liga", "BC Donaustadt 1", 3, 7),
        new("3. Wiener Liga", "URW Wien 4", 7, 7)
    ];

    private readonly IReadOnlyList<BoardRole> _boardRoles =
    [
        new("Praesident", "Marian Gratzer"),
        new("Praesident Stellvertretung", "Medhavi Singh"),
        new("Schriftfuehrer", "Christian Maryska"),
        new("Schriftfuehrer Stellvertretung", "Hanna Faist"),
        new("Kassierin", "Melanie Rainer"),
        new("Kassierin Stellvertretung", "Lisa Humer"),
        new("Sportwartinnen und Sportwarte", "Renate Roedel, Gernot Hoerhager, Daniel Obszelka, Ray Chen, Hanna Buttinger, Ajay Jeyaseelan"),
        new("Nachwuchskoordination", "Marian Gratzer"),
        new("Ballverkauf", "Ray Chen, Bo Cong, Joachim Unger, James McNeil, Melanie Rainer, Michela Polimeni"),
        new("Partysport und Kultur", "Amira Ben Saoud"),
        new("Rechnungspruefung", "Bo Cong und Anna Panko")
    ];

    private readonly IReadOnlyList<ContactChannel> _contactChannels =
    [
        new("E-Mail", "office@urw-badminton.at", "mailto:office@urw-badminton.at", "Bitte bei Mitgliedschaftsanfragen immer Alter und Spielstaerke angeben."),
        new("Postadresse", "Steingasse 26/2/28, 1030 Wien", "https://www.google.com/maps/search/Steingasse+26+1030+Wien", "Fuer offizielle Korrespondenz und Vereinsunterlagen."),
        new("Facebook", "Union Rot-Weiss Badminton Wien", "https://www.facebook.com/people/Union-Rot-Weiss-Badminton-Wien/100026951814177", "Social Updates und Bilder aus dem Vereinsalltag."),
        new("Instagram", "urw_badminton", "https://www.instagram.com/urw_badminton/?hl=de", "Turniermomente, Stories und kurzfristige Einblicke."),
        new("Mitgliederbereich", "Interne Plattform", "https://mitglieder.urw-badminton.at/", "Fuer Vereinsinterna und organisatorische Themen.")
    ];

    private readonly IReadOnlyList<LinkGroup> _linkGroups =
    [
        new(
            "Awareness und Service",
            [
                new("Schutz vor Gewalt", "https://sportunion.at/service/sportbetrieb/schutz-vor-gewalt/", "Praevention, Meldewege und Ansprechpersonen der SPORTUNION Wien."),
                new("SafeSport", "https://safesport.at/kontakt/", "Anonyme Meldestelle fuer uebergriffiges Verhalten im Sport."),
                new("NADA Austria", "http://www.nada.at/", "Anti-Doping Informationen und Richtlinien."),
                new("BSO Abrechnung", "http://www.bso.or.at/de/service/abrechnung-und-kontrolle/abrechnungsrichtlinien/", "Abrechnungsrichtlinien und Formulare fuer Vereine.")
            ]),
        new(
            "Badminton in Wien",
            [
                new("Badmintonverband Wien", "http://www.wienbadminton.at/", "Der Wiener Landesverband mit Turnieren, News und Ausschreibungen."),
                new("BC Donaustadt", "https://www.bc-donaustadt.at/", "Wiener Verein mit Kindertraining."),
                new("Union VRC", "https://www.vrc-badminton.at/", "Einer der grossen Wiener Konkurrenz- und Partnervereine."),
                new("WAT Simmering", "http://www.wat11.at/", "Wiener Verein mit regelmaessigem Ligabetrieb."),
                new("WBH Wien", "http://www.wbh-wien.at/", "Aktiver Wiener Verein mit Nachwuchsangebot."),
                new("BC Wienerberg", "http://www.rbc-sportivo.at/", "Verein im Sueden Wiens mit Kindertraining.")
            ]),
        new(
            "Oesterreich und international",
            [
                new("Badminton Austria", "http://www.badminton.at/", "Bundesverband mit Ranglisten, Ausschreibungen und Nachrichten."),
                new("Badmintonsport", "http://badmintonsport.at/", "News und Shop der Gebrueder Koch."),
                new("Badminton Europe", "http://www.badmintoneurope.com/", "Europaeischer Verband mit Turnier- und Livestream-Infos."),
                new("BWF", "http://internationalbadminton.org/", "Weltverband und internationale Rankings."),
                new("Weltranglisten", "http://bwf.tournamentsoftware.com/ranking/ranking.aspx?rid=70", "Aktuelle BWF Rankings fuer Spielerinnen und Spieler.")
            ]),
        new(
            "Weitere Ressourcen",
            [
                new("Sportunion Wien", "http://www.sportunion-wien.at/", "Dachverband der Wiener SPORTUNION Vereine."),
                new("Sport Austria", "http://www.sport.austria.gv.at/", "Sportpolitische Informationen und Serviceangebote."),
                new("USI Wien", "https://www.usi.at/de/angebot/#!/kurs/4020", "Universitaetssport-Angebote mit Badmintonbezug."),
                new("Tischtennisverband Wien", "http://www.wttv.at/", "Weitere Wiener Racketsport-Adresse."),
                new("Squash Verband Wien", "http://www.wsrv.at/", "Racketsport-Netzwerk ueber Badminton hinaus.")
            ])
    ];

    private readonly IReadOnlyList<BlogPost> _posts =
    [
        new(
            "seniorenmeisterschaften-2026",
            "Seniorenmeisterschaften: Nennung ab sofort moeglich",
            "Der Verein weist fruehzeitig auf die Wiener Senioren-Landesmeisterschaften hin und fasst die wichtigsten Eckdaten fuer Interessierte zusammen.",
            [
                "In rund einem Monat steht in Alt-Erlaa die Wiener Landesmeisterschaft der Seniorinnen und Senioren auf dem Programm. Startberechtigt sind Spielerinnen und Spieler ab 30 Jahren mit aktiver OeBV Lizenz.",
                "Die Kommunikation legt den Fokus auf einfache Planung: Austragungsort, Startzeit, Nennschluss und Staffelung der Startgebuehren werden kompakt aufgefuehrt.",
                "Fuer die moderne Umsetzung eignet sich diese Art Beitrag als serviceorientierter Post mit klaren Fakten, direktem Turnierlink und schnellem Call to Action."
            ],
            "Turniere",
            "Marian Gratzer",
            new DateTime(2026, 3, 4),
            ["Senioren", "WBV", "Turnier"]),
        new(
            "trainingsupdate-fruehjahr",
            "Training und Hallenverfuegbarkeit im Fruehjahr",
            "Wegen Grossveranstaltungen und Heimspielterminen muessen einzelne Trainingseinheiten in Sportarena und Liesing angepasst werden.",
            [
                "Die Hallenplanung nennt zwei Donnerstage in der Sportarena, an denen der Verein wegen Fremdbelegung keine Courts nutzen kann.",
                "Dazu kommen zwei Freitage, an denen entweder nur freies Spielen statt Training moeglich ist oder der Heimspielabend das gesamte Zeitfenster belegt.",
                "In einem modernisierten News-Bereich wird ein solcher Beitrag ideal als schnell erfassbare Service-Meldung mit Terminkacheln und Hallenhinweisen dargestellt."
            ],
            "Training",
            "Marian Gratzer",
            new DateTime(2026, 2, 11),
            ["Training", "Hallen", "Service"]),
        new(
            "wbv-einzel-rlt-urw",
            "WBV Einzel-RLT hosted by URW",
            "Das von URW ausgerichtete Ranglistenturnier wurde organisatorisch gelobt und sportlich von mehreren Vereinsleistungen gepraegt.",
            [
                "Der Bericht hebt die ehrenamtliche Organisation des Turniers hervor und unterstreicht, dass viele Helferinnen und Helfer zum reibungslosen Ablauf beigetragen haben.",
                "Sportlich stand unter anderem ein spannendes vereinsinternes Dameneinzel im Mittelpunkt, dazu kamen starke Auftritte mehrerer URW Spielerinnen und Spieler auf dem Center Court.",
                "Abgerundet wird der Beitrag mit Verweisen auf die Siegerlisten und den naechsten Meldeterminen fuer Mixed und Doppel."
            ],
            "Turniere",
            "Marian Gratzer",
            new DateTime(2026, 2, 9),
            ["RLT", "Ausrichtung", "WBV"]),
        new(
            "staatsmeisterschaften-2026",
            "Die oesterreichischen Staatsmeisterschaften sind entschieden",
            "Der Vereinsbeitrag verlinkt die wichtigsten Medien zum Finaltag und macht so auch externe Spitzensportereignisse fuer die Community sichtbar.",
            [
                "Im Mittelpunkt stehen ein komplett aufbereiteter Livestream des Finaltages sowie eine kompakte Video-Zusammenfassung aus Klagenfurt.",
                "Solche Posts funktionieren im modernisierten Auftritt als kuratierte Vereinsredaktion: nicht nur Eigennachrichten, sondern auch relevante Hinweise auf nationale Highlights.",
                "Die Blazor-Umsetzung zeigt deshalb bewusst verschiedene Beitragstypen, vom Vereinsservice bis zum redaktionellen News-Tipp."
            ],
            "Szene",
            "Marian Gratzer",
            new DateTime(2026, 2, 2),
            ["OeSTM", "Livestream", "Szene"]),
        new(
            "training-30-januar",
            "Training am 30. Januar entfaellt",
            "Eine kurze Service-Meldung kuendigt an, dass die geleitete Einheit ausfaellt, freies Spielen jedoch wie gewohnt stattfinden kann.",
            [
                "Genau fuer solche knappen Hinweise lohnt sich ein News-Modul auf der Startseite: Mitglieder sehen Aenderungen sofort ohne lange Texte durchsuchen zu muessen.",
                "Der Beitrag trennt sauber zwischen Training und freiem Spiel und reduziert Missverstaendnisse vor Ort.",
                "In der modernisierten Variante wird das als kompaktes Alert-Format mit hoher Sichtbarkeit umgesetzt."
            ],
            "Training",
            "Marian Gratzer",
            new DateTime(2026, 1, 28),
            ["Training", "Hinweis", "Freies Spielen"]),
        new(
            "vrc-auswaerts-niederlage",
            "Bittere Niederlage bei VRC, aber noch alles offen",
            "Nach einem knappen 3:5 gegen VRC faellt Team 1 in der Tabelle zurueck, behaelt fuer die kommenden Runden aber alle Chancen.",
            [
                "Der Originalbeitrag verbindet Ergebnisbericht und Ausblick: Der Rueckschlag wird nicht dramatisiert, sondern als Zwischenstand in einer weiter offenen Saison eingeordnet.",
                "Gleichzeitig verweist der Text auf das naechste Heimspiel gegen Simmering und macht daraus einen Mobilisierungsimpuls fuer Verein und Publikum.",
                "Fuer das Redesign ist das ein gutes Beispiel fuer kurze Liga-Berichte mit klarer Dramaturgie und direkter Verknuepfung zum Spielkalender."
            ],
            "Liga",
            "Marian Gratzer",
            new DateTime(2026, 1, 23),
            ["Liga", "1. Mannschaft", "Heimspiel"]),
        new(
            "wiener-meisterschaften-2026",
            "URW blickt gespannt auf die Wiener Meisterschaften",
            "Vor dem Finaltag in der Tellgasse rueckt der Verein mehrere Viertel- und Achtelfinal-Chancen seiner Spielerinnen und Spieler in den Fokus.",
            [
                "Besonders hervorgehoben werden die Offensivqualitaet eines neu formierten Doppels sowie ein Herrendoppel, das seine Form aus dem Ligabetrieb ins Turnier transportiert.",
                "Auch im Herreneinzel sieht der Klub zwei Athleten in aussichtsreicher Position und wirbt entsprechend fuer Unterstuetzung in der Halle.",
                "Der Beitrag zeigt, wie Vereinsmedien Vorfreude erzeugen koennen, ohne den sachlichen Informationscharakter zu verlieren."
            ],
            "Turniere",
            "Marian Gratzer",
            new DateTime(2026, 1, 17),
            ["Wiener Meisterschaften", "Support", "Turnier"]),
        new(
            "rueckrunde-startet",
            "Start der Rueckrunde nach dem X-Mas-Camp",
            "Ein kurzer Ausblick fasst die ersten Heimspiele der Rueckrunde zusammen und bedankt sich indirekt fuer die Vorbereitung im Trainingscamp.",
            [
                "Der Beitrag nennt die naechsten vier Heimtermine in kompakter Form und stellt damit sofort einen Bezug zwischen Training, Saisonplanung und Ligaspielbetrieb her.",
                "Gerade in einer modernen Vereinsseite eignet sich dieser Typ Meldung hervorragend fuer eine Kalenderansicht mit News-Kopplung.",
                "So werden organisatorische Informationen nicht in separaten Bereichen versteckt, sondern redaktionell sichtbar gemacht."
            ],
            "Liga",
            "Marian Gratzer",
            new DateTime(2026, 1, 5),
            ["Rueckrunde", "Heimspiele", "Liga"]),
        new(
            "zukunft-des-federballs",
            "Die Zukunft des Federballs",
            "Ein redaktioneller Hinweis greift die Aussagen des RSL-Chefs zu Produktionsbedingungen und Materialentwicklung bei Shuttlecocks auf.",
            [
                "Der Beitrag verknuepft globale Entwicklungen im Materialbereich mit einem lokalen Vereinskontext, weil Ballqualitaet fuer Training und Wettkampf zentral bleibt.",
                "Damit zeigt die Seite, dass sie nicht nur Termine pflegt, sondern auch Hintergrundthemen fuer interessierte Mitglieder sichtbar macht.",
                "In der modernisierten Version schafft diese Mischung aus Vereinsalltag und Branchenthemen eine glaubwuerdige redaktionelle Breite."
            ],
            "Szene",
            "Marian Gratzer",
            new DateTime(2026, 1, 3),
            ["Federbaelle", "Material", "Hintergrund"])
    ];

    public IReadOnlyList<ClubFact> GetFacts() => _facts;
    public IReadOnlyList<MembershipFee> GetMembershipFees() => _membershipFees;
    public IReadOnlyList<string> GetMembershipBenefits() => _membershipBenefits;
    public IReadOnlyList<string> GetJoinSteps() => _joinSteps;
    public IReadOnlyList<ScheduleSlot> GetSeasonSchedule() => _seasonSchedule;
    public IReadOnlyList<ScheduleSlot> GetSummerSchedule() => _summerSchedule;
    public IReadOnlyList<VenueInfo> GetVenues() => _venues;
    public IReadOnlyList<CoachProfile> GetCoaches() => _coaches;
    public IReadOnlyList<string> GetLevelDescriptions() => _levelDescriptions;
    public IReadOnlyList<string> GetTrainingPrinciples() => _trainingPrinciples;
    public IReadOnlyList<string> GetCompetitionNotes() => _competitionNotes;
    public IReadOnlyList<string> GetCompetitionHighlights() => _competitionHighlights;
    public IReadOnlyList<LeagueStanding> GetLeagueTable() => _leagueTable;
    public IReadOnlyList<LeagueStanding> GetLeagueTable(string league) => _leagueTable.Where(item => item.League.Equals(league, StringComparison.OrdinalIgnoreCase)).ToList();
    public IReadOnlyList<BoardRole> GetBoardRoles() => _boardRoles;
    public IReadOnlyList<ContactChannel> GetContactChannels() => _contactChannels;
    public IReadOnlyList<LinkGroup> GetLinkGroups() => _linkGroups;
    public IReadOnlyList<BlogPost> GetPosts() => _posts.OrderByDescending(post => post.PublishedOn).ToList();
    public IReadOnlyList<BlogPost> GetRecentPosts(int count) => _posts.OrderByDescending(post => post.PublishedOn).Take(count).ToList();
    public BlogPost? GetPostBySlug(string slug) => _posts.FirstOrDefault(post => post.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));

    public IReadOnlyList<string> GetFreePlayRules() =>
    [
        "Wenn alle Courts belegt sind, gilt die Ein-Satz-Regel, damit die Wartezeiten fair bleiben.",
        "Netze werden fuenf Minuten vor Hallenschluss abgebaut und die Halle puenktlich verlassen.",
        "Gut spielbare gebrauchte Baelle gehen zurueck in die Trainingsballkiste, kaputte Baelle werden entsorgt.",
        "Nie knapp durch laufende Ballwechsel gehen, weil das stoert und Verletzungsrisiken erhoeht."
    ];

    public IReadOnlyList<LinkItem> GetInformationDocuments() =>
    [
        new("ZVR Abfrage", "http://zvr.bmi.gv.at/Start", "Vereinsregister mit der ZVR Zahl 802964403."),
        new("Statuten", "http://urw-badminton.at/sites/default/files/URW_Statuten_2020_web.pdf", "Vereinsstatuten als PDF."),
        new("Wettspielordnung WBV", "http://www.urw-badminton.at/webfm_send/23", "Rahmen fuer den Wiener Meisterschaftsbetrieb."),
        new("Turnierbestimmungen WBV", "http://www.urw-badminton.at/webfm_send/33", "Grundlagen fuer Nennungen und Bewerbe."),
        new("Spielbericht MMS", "http://www.urw-badminton.at/webfm_send/16", "Vorlage fuer den Mannschaftsmeisterschaftsbetrieb.")
    ];
}