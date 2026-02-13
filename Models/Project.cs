namespace PortfolioSite.Models;

public class Project
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Year { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public List<string> Tags { get; set; } = new();
    public List<ProjectLink> Links { get; set; } = new();
}

public class ProjectLink
{
    public string Label { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}

public class TimelineEntry
{
    public string Year { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string IconType { get; set; } = string.Empty; // life, work, edu
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

public class Book
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Year { get; set; } = string.Empty;
    public bool IsStarred { get; set; }
    public string Category { get; set; } = string.Empty; // "current", "past-favorites"
}
