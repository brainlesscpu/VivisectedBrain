using System.Collections.Generic;
using System.Linq;
using VivisectedBrain.Models;

namespace VivisectedBrain.Services;

public class ArchiveCatalog{

    private readonly List<ArchiveEntry> _entries = new ();

    public void AddEntry(ArchiveEntry entry)
    {
        _entries.Add(entry);
    }

    public List<ArchiveEntry> GetAllEntries()
    {
        return _entries;
    }

    public List<ArchiveEntry> GetEntriesByCategory(EntryCategory category)
    {
        return _entries
            .Where(entry => entry.Category == category)
            .ToList();
    }

}