VIVISECTED BRAIN - DATA MODEL

# 1. Overview
The data model defines the structure of information stored within this project.

The primary entity is ArchiveEntry.

Each archive entry represents an individual item that the user wants to catalog.

# 2. ArchiveEntry
ArchiveEntry represents an individual record in the archive.

Id (int) - Unique identifier for the entry
Title (string) - Name of the archive entry
Description (string) - Additional information about the entry
Category (EntryCategory) - Classification of the entry
DateAdded (DateTime) - Date the entry was created

# 3. EntryCategory
EntryCategory defines the available classifications.

Current categories:
* Movie
* VideoGame
* Book
* Cryptid
* Monster
* Fish
* Insect

Additional categories may be introduced as the application evolves.

# 4. Relationships
Archive entries may eventually reference other archive entires
(e.g. different games may contain related creatures or concepts).

These relationships are intended to support future discovery and recommendation functionality.

# 5. Future Development
Potential additions:
* Entry relationships
* User ratings
* Tags and keywords
* External references
* Media attachments