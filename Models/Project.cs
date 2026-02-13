namespace PortfolioSite.Models;

public class Project
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public bool IsFeatured { get; set; }
    public List<string> Technologies { get; set; } = new();
    public List<ProjectLink> Links { get; set; } = new();
}

public class ProjectLink
{
    public string Label { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}
