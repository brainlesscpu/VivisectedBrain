using Xunit;
using Xunit.Abstractions;
using VivisectedBrain.Models;
using VivisectedBrain.Services;

namespace VivisectedBrain.Tests;


public class ArchiveCatalogTests
{
    [Fact]
    public void AddEntry_ShouldStoreEntry()
    {
        ArchiveCatalog testCatalog = new ArchiveCatalog();

        ArchiveEntry testEntry = new ArchiveEntry("Title", "Description",   EntryCategory.Cryptid);

        testCatalog.AddEntry(testEntry);

        int catalogCt = testCatalog.GetAllEntries().Count;

        _output.WriteLine($"Title: {testEntry.Title}");
        _output.WriteLine($"Description: {testEntry.Description}");
        _output.WriteLine($"Category: {testEntry.Category}");

        Assert.Equal(EntryCategory.Cryptid, testCatalog.GetAllEntries()[0].Category);
        Assert.Same(testEntry, testCatalog.GetAllEntries()[0]);
    }

    [Fact]
    public void GetAllEntries_ShouldReturnAllEntries()
    {
        ArchiveCatalog testCatalog = new ArchiveCatalog();

        ArchiveEntry testEntry1 = new ArchiveEntry("Title1", "Description1", EntryCategory.Cryptid);
        ArchiveEntry testEntry2 = new ArchiveEntry("Title2", "Description2", EntryCategory.VideoGame);

        testCatalog.AddEntry(testEntry1);
        testCatalog.AddEntry(testEntry2);

        var allEntries = testCatalog.GetAllEntries();

        Assert.Equal(2, allEntries.Count);
        Assert.Contains(testEntry1, allEntries);
        Assert.Contains(testEntry2, allEntries);
    }

    [Fact]
    public void GetEntriesByCategory_ShouldReturnCorrectEntries()
    {
        ArchiveCatalog testCatalog = new ArchiveCatalog();

        ArchiveEntry testEntry1 = new ArchiveEntry("Title1", "Description1", EntryCategory.Cryptid);
        ArchiveEntry testEntry2 = new ArchiveEntry("Title2", "Description2", EntryCategory.VideoGame);
        ArchiveEntry testEntry3 = new ArchiveEntry("Title3", "Description3", EntryCategory.Cryptid);

        testCatalog.AddEntry(testEntry1);
        testCatalog.AddEntry(testEntry2);
        testCatalog.AddEntry(testEntry3);

        var cryptidEntries = testCatalog.GetEntriesByCategory(EntryCategory.Cryptid);

        Assert.Equal(2, cryptidEntries.Count);
        Assert.Contains(testEntry1, cryptidEntries);
        Assert.Contains(testEntry3, cryptidEntries);
        Assert.DoesNotContain(testEntry2, cryptidEntries);
    }

    [Fact]
    public void EmptyCatalog_ShouldReturnEmptyList()
    {
        ArchiveCatalog testCatalog = new ArchiveCatalog();

        var allEntries = testCatalog.GetAllEntries();
        var cryptidEntries = testCatalog.GetEntriesByCategory(EntryCategory.Cryptid);
        
        Assert.Empty(allEntries);
        Assert.Empty(cryptidEntries);
    }

    private readonly ITestOutputHelper _output;

    public ArchiveCatalogTests(ITestOutputHelper output){
        _output = output;
    }
}