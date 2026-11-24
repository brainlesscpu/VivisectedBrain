VIVISECTED BRAIN - TESTING STRATEGY

# 1. Overview
This project uses automated unit testing to verify application logic and ensure that individual components behave as expected.

# 2. Testing Framework
Framework: xUnit
Language: C#
Test Project: VivisectedBrain.Tests

# 3. Testing Approach
Tests follow the Arrange-Act-Assert (AAA) pattern.

## Arrange
Create the necessary objects and establish the initial conditions.

## Act
Execute the method or operation being tested.

## Assert
Verify that the result matches the expected behavior.

# 4. ArchiveCatalog Tests
Current test coverage includes:

## AddEntry_ShouldStoreEntry - Entry is successfully stored
## GetAllEntries_ShouldReturnAllEntries - All stored entries are returned
## GetEntriesByCategory_ShouldReturnCorrectEntries - Only matching categories
## EmptyCatalog_ShouldReturnEmptyList - No entries are stored so nothing should be returned

# 5. Planned Tests
* Duplicate entries are rejected.
* Duplicate detection handles capitalization and whitespace according to the defined rules.

# 6. Running Tests
Execute the complete test suite using:

dotnet test VivisectedBrain.Tests

# 7. Testing Philosophy
Application logic should be tested independently of the user interface.

Tests should verify both expected behavior and edge cases.