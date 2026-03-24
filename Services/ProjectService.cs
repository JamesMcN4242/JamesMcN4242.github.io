using PortfolioSite.Models;

namespace PortfolioSite.Services;

public class ProjectService
{
    private readonly List<Project> _projects = new()
    {
        new Project
        {
            Id = "simcorp-gain-dmc",
            Title = "SimCorp Gain / Data Management Core",
            Summary = "Working on the Data Management Core product within SimCorp Gain, an investment management platform.",
            Description = "At SimCorp I work on the Data Management Core (DMC) product, part of the SimCorp Gain investment management platform. DMC is responsible for managing and distributing financial data across the platform, serving as the central data backbone for portfolio management, risk analysis, and reporting.\n\nMy work involves full-stack development across the product, working with a modern tech stack to build and maintain features that handle large volumes of financial data. The role requires close collaboration with other teams across the organisation to ensure data consistency and reliability throughout the platform.\n\nA highlight of my time here has been identifying opportunities to optimise our cloud infrastructure for the cloud offering. Through discovering inefficiencies, managing the initiative, and implementing architectural changes, I helped reduce production costs by 25% — all while maintaining the high performance and reliability our clients depend on.\n\nThis has been a fantastic opportunity to work in the fintech space, applying my generalist programming skills to complex domain problems in financial services.",
            Category = "Industry",
            Date = new DateTime(2024, 1, 1),
            IsFeatured = true,
            Technologies = new List<string> { "C#", "TypeScript", "Angular", "SQL", "Azure", "Oracle", "Snowflake" },
            Links = new List<ProjectLink>()
        },
        new Project
        {
            Id = "csr-racing-2",
            Title = "CSR Racing 2",
            Summary = "Working as part of a multi studio team to provide live updates to CSR Racing 2.",
            Description = "As part of a supporting team to Natural Motion's CSR Racing 2, my work focused primarily on SDK updates, system refactors and bug fixing.\n\nTo the time of writing, this has been the biggest project I've worked on in terms of team size. With multiple studios and teams being involved in the upkeep of the project. It has been an interesting experience working with developers from such vastly different timezones, which was a great learning experience in how to resolve the set of communication issues that can arise as a result of these time differences.",
            Category = "Industry",
            Date = new DateTime(2020, 12, 18),
            IsFeatured = true,
            Technologies = new List<string> { "C#", "Unity", "SDK Integration", "Multi-Studio Collaboration" },
            Links = new List<ProjectLink>
            {
                new() { Label = "Android", Url = "https://play.google.com/store/apps/details?id=com.naturalmotion.customstreetracer2" },
                new() { Label = "iOS", Url = "https://apps.apple.com/us/app/csr-racing-2-1-racing-games/id887947640" }
            }
        },
        new Project
        {
            Id = "pocket-mortys-live-ops",
            Title = "Pocket Mortys Live Ops",
            Summary = "Assisting in providing updates to the Pocket Mortys game, including the creation of raid events.",
            Description = "In preparation for Season 4 of Rick and Morty a number of updates were created to pique interest in the Pocket Morty game. Including general quality of life improvements, SDK updates and collaborating in the creation of raid events.\n\nWorking as part of a team to supply these updates to a large user base has been a great development opportunity. It allowed me to work with a large variety of languages including C#, Objective-C, JavaScript and SQL.\n\nThe raid event that recently ran for the first time was the biggest technological challenge I've had the pleasure of working on within my time in the games industry.",
            Category = "Industry",
            Date = new DateTime(2019, 10, 23),
            IsFeatured = true,
            Technologies = new List<string> { "C#", "Objective-C", "JavaScript", "SQL", "Unity" },
            Links = new List<ProjectLink>
            {
                new() { Label = "iOS", Url = "https://apps.apple.com/us/app/rick-and-morty-pocket-mortys/id992640880" },
                new() { Label = "Android", Url = "https://play.google.com/store/apps/details?id=com.turner.pocketmorties" }
            }
        },
        new Project
        {
            Id = "raith-rovers-matchday-app",
            Title = "Raith Rovers Matchday App",
            Summary = "Working on the update to the Raith Rovers Matchday App for the 2019 football season.",
            Description = "In order to support the launch of the 2019 football season, I worked on the Raith Rovers Matchday App update. The main brunt of the work went into:\n\n\u2022 Implementing the Raith Invaders game mode from the established framework\n\u2022 Introducing push notifications to the project\n\u2022 Creating an in-app leaderboard for collecting points throughout the season and all time\n\u2022 Finalising an in-game mailing system",
            Category = "Industry",
            Date = new DateTime(2019, 10, 23),
            IsFeatured = true,
            Technologies = new List<string> { "Mobile Development", "Push Notifications", "Leaderboards", "Unity" },
            Links = new List<ProjectLink>
            {
                new() { Label = "iOS", Url = "https://apps.apple.com/gb/app/raith-rovers-matchday-app/id1421285626" },
                new() { Label = "Android", Url = "https://play.google.com/store/apps/details?id=com.taggames.raithrovers" }
            }
        },
        new Project
        {
            Id = "vr-experiment",
            Title = "VR Experiment",
            Summary = "A VR prototype in Unity inspired by Space Pirate Trainer, featuring projectile-based gameplay.",
            Description = "Having been a long time VR enthusiast, I decided to try my luck at creating a basic VR prototype in Unity. The concept itself was very simple, and took inspiration from the endlessly fun game, Space Pirate Trainer. Instead of having robots to destroy as you dodged their shots, I instead made the projectiles the target to aim at. It became almost like a boxing game where you had to strike the target before it hit your head.\n\nHaving realised very early on I was bad at my own game, I created a scalable difficulty menu where I could set the max number of blocks coming at any one time. As well as the angle around the player's vision the blocks could spawn from.",
            Category = "Personal",
            Date = new DateTime(2022, 10, 3),
            IsFeatured = false,
            Technologies = new List<string> { "C#", "Unity", "VR", "UI Design" },
            Links = new List<ProjectLink>()
        },
        new Project
        {
            Id = "budgeting-app",
            Title = "Budgeting App",
            Summary = "A simplistic Android budgeting app built in Unity for personal finance tracking.",
            Description = "While trying to keep track of my finances I noticed more and more that there were no apps that did only the small subset of things I wanted. Or required personal information and bank access to do it. For this reason I decided to make a simplistic Android app that I could add the values to myself and get very quick visual feedback as to whether I was doing well or badly for a given month.\n\nAs a result this weekend project was born. I used Unity and relied heavily on their UI anchoring to create this application. The app has \"Fixed\" and \"Variable\" values that can be added to it. Fixed values roll over to the next month, whereas the Variable values are saved as a total for the month, and then the list is cleared when a new month begins.\n\nBy saving these values I could easily display graphs of how a set of months looked, as well as a quick view screen of the current month.",
            Category = "Personal",
            Date = new DateTime(2020, 9, 27),
            IsFeatured = false,
            Technologies = new List<string> { "C#", "Unity", "Android", "UI/UX" },
            Links = new List<ProjectLink>
            {
                new() { Label = "GitHub", Url = "https://github.com/JamesMcN4242/BudgetingApp" }
            }
        },
        new Project
        {
            Id = "community-easter-egg-hunt",
            Title = "Community Easter Egg Hunt",
            Summary = "A last-minute Easter egg hunt game created for a community trust during COVID-19.",
            Description = "A friend involved deeply with the Cambusbarron Community Development Trust (CCDT) made a last minute request to create a very simplistic easter egg hunt game. This was to give children an activity in place of the previously planned outdoor activities in the community that were cancelled due to COVID-19.\n\nThe game itself was very simplistic with just a few components required. Given time I would have liked to include sound effects, add a hints system or equivalent to not make it such random seeming gameplay. However given the time restrictions and few hours available that week I'm glad to have been able to get something for the kids to play on Easter morning.",
            Category = "Personal",
            Date = new DateTime(2020, 9, 27),
            IsFeatured = false,
            Technologies = new List<string> { "C#", "Unity", "WebGL" },
            Links = new List<ProjectLink>
            {
                new() { Label = "Play on Simmer.io", Url = "https://simmer.io/@JamesMcN42/cambusbarron-egg-hunt" },
                new() { Label = "GitHub", Url = "https://github.com/JamesMcN4242/EasterEggHunt" }
            }
        },
        new Project
        {
            Id = "space-invaders-streaming-service",
            Title = "Space Invaders Streaming Service",
            Summary = "A C++ client-server networking project demonstrating real-time game streaming.",
            Description = "Two separate programmes were created as part of this dive into networking to demonstrate data sharing. Both applications were created with the C++ programming language. One was classed as a server, which acted as the gameplay window. Through this a user could play a game of space invaders, which would reset should the player win or lose. Additionally a client window was created that allowed a user to connect to a launched server (if present) and watch the game unfold before them.\n\nWhen a server was closed, the client would be displayed a message that the server had stopped responding or gone offline, before returning to its initial screen where a user could try to reconnect to a server.\n\nThis was my first ever dive into networking code, especially at such a deep level. Looking back at this project with the benefit of hindsight I can happily say it was one that gave me a good foundation into the workings of a networked system (client-server) that has been very beneficial in my career thus far.",
            Category = "Personal",
            Date = new DateTime(2018, 1, 15),
            IsFeatured = false,
            Technologies = new List<string> { "C++", "Networking", "Client-Server Architecture" },
            Links = new List<ProjectLink>()
        },
        new Project
        {
            Id = "relative-rumble",
            Title = "Relative Rumble",
            Summary = "A two player brawler game created at the 2019 Global Game Jam.",
            Description = "Relative Rumble is a two player brawler game created at the 2019 Global Game Jam. The game was designed and developed over the course of the jam weekend, focusing on fast-paced competitive gameplay between two local players.",
            Category = "Game Jam",
            Date = new DateTime(2019, 6, 4),
            IsFeatured = true,
            Technologies = new List<string> { "C#", "Unity", "Game Jam", "Local Multiplayer" },
            Links = new List<ProjectLink>()
        },
        new Project
        {
            Id = "mixin-matchin-and-reaction",
            Title = "Mixin, Matchin and Reaction",
            Summary = "A chemistry sandbox serious game created for St Andrews University at a game jam.",
            Description = "This game was created in answer to a brief by Saint Andrews University, for a serious game jam hosted at Abertay, completed over a total of two and a half days. The brief was from the chemistry department that wished for a game that could be given to new students, to stop them feeling so overwhelmed when they first entered a lab.\n\nOur approach to completing the set out brief was to create a sandbox style game. This allowed players to mix chemicals together and see what reaction this may create. It was hoped that by allowing students to play around with the chemicals in the game, they'd feel more confident about the knowledge of the tasks ahead, as well as the importance of following instructions. Since some reactions could be harmful if not properly prepared for.\n\nThe final build was made to work on both the PC and an Android mobile.",
            Category = "Game Jam",
            Date = new DateTime(2018, 1, 14),
            IsFeatured = false,
            Technologies = new List<string> { "C#", "Unity", "Educational Games", "Android" },
            Links = new List<ProjectLink>
            {
                new() { Label = "Download", Url = "https://drive.google.com/open?id=1wtKTD2xyhfXE1sIUUwSOseiBs9Qe2ScX" }
            }
        },
        new Project
        {
            Id = "std-rpg",
            Title = "STD RPG",
            Summary = "A comedic, slightly educational RPG created at the Global Game Jam in the South Park style.",
            Description = "STD RPG was meant as a joking, but slightly educational, game in the South Park style.\n\nAs part of the Global Game Jam I worked as the sole programmer of STD RPG with the team We'll Be Right Back. Much like the team name suggests, none of us were quite able to work anywhere near the 48 hours due to other commitments, so the final build is the product of about 13-16 hours of work.\n\nThis game was made in Unity and is playable on both Android and PC.",
            Category = "Game Jam",
            Date = new DateTime(2018, 2, 3),
            IsFeatured = false,
            Technologies = new List<string> { "C#", "Unity", "Game Jam", "Android" },
            Links = new List<ProjectLink>
            {
                new() { Label = "Download", Url = "https://drive.google.com/open?id=1Go7eux9KoVeP-eQvMIRzogPKwI-fAkjB" }
            }
        },
        new Project
        {
            Id = "when-the-cull-begins",
            Title = "When The Cull Begins",
            Summary = "A game jam project exploring survival mechanics and strategic gameplay.",
            Description = "When The Cull Begins was a game created during a game jam, challenging players with survival mechanics and strategic decision-making within a limited timeframe.",
            Category = "Game Jam",
            Date = new DateTime(2018, 3, 4),
            IsFeatured = false,
            Technologies = new List<string> { "C#", "Unity", "Game Jam" },
            Links = new List<ProjectLink>()
        },
        new Project
        {
            Id = "play",
            Title = "Play / AI Experiment",
            Summary = "A collection of mini-games built in Blazor — work in progress, best on desktop.",
            Description = "An experiment to see if AI could generate simple games in Blazor that could be hosted via GitHub Pages. Includes three tabbed mini-games: Creature Catcher (grid-based creature-collection exploration), Floppy Bird (grid-based clone), and Snake (classic 20x20 grid).\n\nThis is a work in progress and doesn't fully work on mobile yet. Best experienced on a desktop browser with keyboard controls.",
            Category = "AI Experiments",
            Date = new DateTime(2026, 3, 1),
            IsFeatured = false,
            Technologies = new List<string> { "Blazor", "C#", "Games", "AI-Generated" },
            Links = new List<ProjectLink>()
        },
        new Project
        {
            Id = "particle-universe",
            Title = "Particle Universe",
            Summary = "Interactive particle physics demo built in Blazor with gravity, trails, and bouncing.",
            Description = "An interactive particle simulation built entirely in Blazor WebAssembly. Click or touch anywhere on the canvas to spawn colorful particles that respond to gravity, bounce off walls, and leave trails.\n\nFeatures adjustable gravity strength, spawn count, and trail length. Particles have randomized colors, sizes, velocities, and lifespans. The simulation supports up to 500 particles with real-time FPS tracking.\n\nBuilt to test the limits of Blazor's rendering performance for real-time interactive content without any JavaScript canvas — all rendering is done via CSS-positioned div elements.",
            Category = "AI Experiments",
            Date = new DateTime(2026, 3, 1),
            IsFeatured = false,
            Technologies = new List<string> { "Blazor", "C#", "CSS", "Physics", "AI-Generated" },
            Links = new List<ProjectLink>()
        },
        new Project
        {
            Id = "shaderlab",
            Title = "ShaderLab",
            Summary = "Write math expressions to generate animated pixel art with a custom expression parser.",
            Description = "A creative coding tool built in Blazor that lets you write mathematical expressions for R, G, and B color channels using variables x, y, and t (time) to generate animated pixel art.\n\nFeatures a custom recursive-descent expression parser supporting trigonometric functions (sin, cos, tan), math operations (abs, sqrt, floor, ceil, min, max, pow, mod, fract, step, clamp, smoothstep), ternary expressions, and comparisons.\n\nIncludes 7 built-in presets (Plasma, Rings, Checkers, Gradient, Waves, Fire, Matrix), adjustable resolution from 16x16 to 64x64, and animation speed control.",
            Category = "AI Experiments",
            Date = new DateTime(2026, 3, 1),
            IsFeatured = false,
            Technologies = new List<string> { "Blazor", "C#", "Parsing", "Math", "AI-Generated" },
            Links = new List<ProjectLink>()
        },
        new Project
        {
            Id = "text-compare",
            Title = "Text Compare",
            Summary = "A text diff comparison tool with word-level highlighting built in Blazor.",
            Description = "A side-by-side text comparison tool that uses a Longest Common Subsequence (LCS) algorithm to compute line-level differences between two pieces of text.\n\nWhen consecutive removed and added lines are detected, they're paired and diffed at the word level — highlighting individual changed words rather than entire lines. This makes it easy to spot small changes within large blocks of text.\n\nBuilt entirely in Blazor with no external dependencies.",
            Category = "AI Experiments",
            Date = new DateTime(2026, 3, 1),
            IsFeatured = false,
            Technologies = new List<string> { "Blazor", "C#", "Diff", "AI-Generated" },
            Links = new List<ProjectLink>()
        }
    };

    public IReadOnlyList<Project> GetAllProjects() => _projects.AsReadOnly();

    public IReadOnlyList<Project> GetFeaturedProjects() =>
        _projects.Where(p => p.IsFeatured).OrderByDescending(p => p.Date).ToList().AsReadOnly();

    public IReadOnlyList<Project> GetProjectsByCategory(string category) =>
        _projects.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                 .OrderByDescending(p => p.Date)
                 .ToList()
                 .AsReadOnly();

    public Project? GetProjectById(string id) =>
        _projects.FirstOrDefault(p => p.Id.Equals(id, StringComparison.OrdinalIgnoreCase));

    public IReadOnlyList<string> GetCategories() =>
        _projects.Select(p => p.Category).Distinct().OrderBy(c => c).ToList().AsReadOnly();
}
