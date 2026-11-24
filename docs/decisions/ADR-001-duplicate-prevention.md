ADR-001: DUPLICATE ARCHIVE ENTRY PREVENTION

# Status
Proposed

# Context
This project allows users to add entries to a centralized archive catalog.

Without duplicate prevention, users could accidentally add identical entries multiple times.

This could create inconsistencies when filtering, searching, or recommending related entries.

# Decision
An archive entry will be considered a duplicate when its:

1. Title
2. Description
3. Category

match an existing entry.

Duplicate validation will be handled by ArchiveCatalog rather than the user interface.

# Consequences
## Positive:
* Reduces accidental duplicate records.
* Centralizes validation logic.
* Keeps duplicate prevention consistent across the application.

## Considerations:
* Case sensitivity must be defined.
* Whitespace normalization must be defined.
* The behavior of rejected entries must be established.

# Testing Requirements
Unit tests should verify:
* A unique entry can be added.
* An identical entry is rejected.
* Differences in category are handled correctly.
* Capitalization and whitespace follow the defined comparison rules.