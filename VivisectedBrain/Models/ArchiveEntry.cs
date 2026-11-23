using System;

namespace VivisectedBrain.Models;

public class ArchiveEntry
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public EntryCategory Category { get; set; }

    public DateTime DateAdded { get; set; } = DateTime.Now;

    public ArchiveEntry(string title, string description, EntryCategory category)
    {
        Title = title;
        Description = description;
        Category = category;
    }

}