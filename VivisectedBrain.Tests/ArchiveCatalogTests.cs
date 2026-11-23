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

        Assert.Equal(1, catalogCt);
    }

    private readonly ITestOutputHelper _output;

    public ArchiveCatalogTests(ITestOutputHelper output){
        _output = output;
    }
}