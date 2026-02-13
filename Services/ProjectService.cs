using PortfolioSite.Models;

namespace PortfolioSite.Services;

public class ProjectService
{
    private readonly List<Project> _projects = new()
    {
        new Project
        {
            Id = "nulirg",
            Title = "NULIRG",
            Summary = "Research project combining machine learning with astrophysics data analysis.",
            Description = "Research project combining machine learning with astrophysics data analysis at the University of Minnesota.",
            Year = "2017-2019",
            ImageUrl = "https://sourabhsc.onrender.com/static/projects/nulirg/logo.png",
            Tags = new List<string> { "ML", "HST" },
            Links = new List<ProjectLink>
            {
                new() { Label = "Full Details", Url = "https://nulirg.herokuapp.com/index.html" }
            }
        },
        new Project
        {
            Id = "vbd",
            Title = "VBD Xray Challenge",
            Summary = "Kaggle competition to identify bounding boxes for 14 different X-ray anomalies using deep learning.",
            Description = "This was a Kaggle competition which aims at identifying bounding boxes for 14 different X-ray anomalies using a dataset of 15000 images. Train dataset images had been annotated by 3 radiologists while the test images have been annotated by 5 radiologists.\n\n• Wrote an EDA notebook on Kaggle which gave a bronze medal.\n• Used FasterRCNN from Detectron2 model for bounding box prediction.\n• Used Weighted Box fusion to merge boxes from different radiologists.\n• Used YoloV5 for training which works better than the FasterRCNN algorithm.\n\nFindings:\n• Some anomalies work better on smaller size images while some work better on larger size images.\n• Fusing the boxes did not result in better results.",
            Year = "2021",
            ImageUrl = "https://sourabhsc.onrender.com/static/projects/vbd/vbd-icon-img.jpg",
            Tags = new List<string> { "ML", "Kaggle" },
            Links = new List<ProjectLink>
            {
                new() { Label = "W&B Report", Url = "https://wandb.ai/sourabhsc/vbd-xrays-hyperparam/reports/VinBigData-Chest-X-ray-challenge--Vmlldzo2MDE3OTQ" },
                new() { Label = "EDA Notebook", Url = "https://www.kaggle.com/sourabhchauhan/chest-x-ray-abnormalities-eda-box-fuse-skew" }
            }
        },
        new Project
        {
            Id = "phymanim",
            Title = "PhyManim",
            Summary = "Built Manim videos for physics education — Reflection and Refraction chapter in Optics with no language constraints.",
            Description = "Built Manim videos for Reflection and Refraction chapter in Optics with no language constraints. The videos can be translated and used by any language student with a small change. Videos will be released on the Apni Class YouTube Channel.",
            Year = "2020",
            ImageUrl = "https://sourabhsc.onrender.com/static/projects/phymanim/manim-logo.svg",
            Tags = new List<string> { "ML", "HST" },
            Links = new List<ProjectLink>
            {
                new() { Label = "Manim Library", Url = "https://github.com/3b1b/manim" },
                new() { Label = "Apni Class YouTube", Url = "https://www.youtube.com/c/ApniClassOfficial/" }
            }
        },
        new Project
        {
            Id = "apni-class",
            Title = "Apni Class Campaign",
            Summary = "Led the fundraiser for Apni Class EdTech startup; built custom donation dashboard and mobile app login.",
            Description = "Led the fundraiser for Apni Class, an EdTech startup.\n\n• Built a custom dashboard for the company to track live donations using API requests and Bokeh server.\n• Built the login page for the Apni Class mobile application.",
            Year = "2020",
            ImageUrl = "https://sourabhsc.onrender.com/static/projects/apni-class/logo.png",
            Tags = new List<string> { "ML", "HST" },
            Links = new List<ProjectLink>
            {
                new() { Label = "Fundraiser", Url = "https://www.ketto.org/fundraiser/apni-class" }
            }
        },
        new Project
        {
            Id = "wns-ctr",
            Title = "CTR Prediction",
            Summary = "Click-through rate prediction using machine learning for WNS Analytics competition.",
            Description = "Click-through rate prediction project using machine learning techniques for the WNS Analytics competition on Kaggle.",
            Year = "2019",
            ImageUrl = "https://sourabhsc.onrender.com/static/projects/wns-ctr/logo.png",
            Tags = new List<string> { "ML", "HST" },
            Links = new List<ProjectLink>
            {
                new() { Label = "Kaggle EDA", Url = "https://www.kaggle.com/sourabhchauhan/wns-analytics-competitions-eda" }
            }
        },
        new Project
        {
            Id = "dharavicovid",
            Title = "Dharavi COVID",
            Summary = "Geospatial web application tracking COVID-19 spread in Dharavi using image processing and mapping.",
            Description = "Geospatial web application tracking COVID-19 spread in Dharavi, built with Flask.",
            Year = "2020",
            ImageUrl = "https://sourabhsc.onrender.com/static/projects/dharavicovid/logo.png",
            Tags = new List<string> { "IMG", "GEO", "Web" },
            Links = new List<ProjectLink>
            {
                new() { Label = "Blog Post", Url = "https://sourabhsc.wordpress.com/flask-projects" },
                new() { Label = "Platform", Url = "https://dharavicovid.herokuapp.com/" }
            }
        },
        new Project
        {
            Id = "bikeshare",
            Title = "Bikeshare",
            Summary = "Geospatial Flask web application for bike sharing analysis and visualization.",
            Description = "Geospatial web application built with Flask for bike sharing analysis and visualization.",
            Year = "2020",
            ImageUrl = "https://sourabhsc.onrender.com/static/projects/bikeshare/logo.png",
            Tags = new List<string> { "GEO", "Web", "Flask" },
            Links = new List<ProjectLink>
            {
                new() { Label = "DevPost", Url = "https://devpost.com/software/share-your-bike" }
            }
        }
    };

    private readonly List<TimelineEntry> _timeline = new()
    {
        new TimelineEntry
        {
            Year = "2021",
            IconType = "life",
            Title = "Exercise and Food",
            Description = "Moved to Vienna in May 2021 from Klosterneuburg."
        },
        new TimelineEntry
        {
            Year = "2021",
            IconType = "work",
            Title = "Kaggle VBD Xray Challenge",
            Description = "Spent 1.5 months (Feb - March) working on Kaggle VBD challenge to identify 14 Xray anomalies in more than 15000 X-ray images using deep learning algorithms."
        },
        new TimelineEntry
        {
            Year = "2021",
            IconType = "edu",
            Title = "German A1",
            Description = "Spent ~4 months, 2 hours a week learning German. Can now have everyday conversations limited to a certain topic."
        },
        new TimelineEntry
        {
            Year = "2015-2021",
            IconType = "work",
            Title = "More details coming soon...",
            Description = "Career timeline details to be expanded."
        }
    };

    private readonly List<Book> _books = new()
    {
        new Book
        {
            Title = "Cracking the Coding Interview",
            Description = "Nice book to brush up your coding basics.",
            Year = "2021",
            IsStarred = true,
            Category = "current"
        },
        new Book
        {
            Title = "Weapons of Math Destruction",
            Description = "A nice book for ethics in AI and explainable AI by Cathy O'Neil. (currently reading)",
            Year = "2021",
            IsStarred = true,
            Category = "current"
        },
        new Book
        {
            Title = "Business Model You",
            Description = "A quite informative book for reinventing your career.",
            Year = "2021",
            IsStarred = false,
            Category = "current"
        },
        new Book
        {
            Title = "Storytelling With Data",
            Description = "Quick primer for data visualization tools.",
            Year = "2021",
            IsStarred = false,
            Category = "current"
        },
        new Book
        {
            Title = "Hands-On Machine Learning with SciKit-Learn & TensorFlow",
            Description = "Beginner book for Machine Learning by Aurelien Geron.",
            Year = "2021",
            IsStarred = false,
            Category = "current"
        },
        new Book
        {
            Title = "Emotional Intelligence",
            Description = "A foundational read on understanding and managing emotions.",
            Year = "",
            IsStarred = true,
            Category = "past-favorites"
        }
    };

    public IReadOnlyList<Project> GetAllProjects() => _projects.AsReadOnly();

    public IReadOnlyList<Project> GetProjectsByTag(string tag) =>
        _projects.Where(p => p.Tags.Any(t => t.Equals(tag, StringComparison.OrdinalIgnoreCase)))
                 .ToList().AsReadOnly();

    public Project? GetProjectById(string id) =>
        _projects.FirstOrDefault(p => p.Id.Equals(id, StringComparison.OrdinalIgnoreCase));

    public IReadOnlyList<string> GetAllTags() =>
        _projects.SelectMany(p => p.Tags).Distinct().OrderBy(t => t).ToList().AsReadOnly();

    public IReadOnlyList<TimelineEntry> GetTimeline() => _timeline.AsReadOnly();

    public IReadOnlyList<string> GetTimelineYears() =>
        _timeline.Select(t => t.Year).Distinct().ToList().AsReadOnly();

    public IReadOnlyList<Book> GetBooks(string category) =>
        _books.Where(b => b.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
              .ToList().AsReadOnly();
}
