VIVISECTED BRAIN - APPLICATION ARCHITECTURE

# 1. Overview
This project is a personal digital archive application designed to catalog and organize the user's interests, discoveries, and experiences.

The application uses a desktop interface with a structured data model and a service layer responsible for managing archive entires.

# 2. Technology Stack
C# - Primary programming language
.NET 10 - Application framework
Avalonioa UI - Cross-platform desktop interface
MVVM - Application architectural pattern
xUnit - Unit testing
Git - Version Control
GitHub - Remote repository hosting

# 3. Project Structure
## Models
Contains the application's data structures and domain definitions.

## Services
Contains application logic and operations that manage archive data.

## Views
Contains the visual components of the desktop application.

## ViewModels
Connects the application data and functionality to the user interface.

## Tests
Contains automated tests that verify application behavior.

# 4. Architectural Principles
* Separate application logic from the user interface.
* Keep data models independent of presentation logic.
* Centralize archive management within the service layer.
* Use automated tests to verify important application behavior.
* Keep the application modular to support future expansion.

# 5. Future Considerations
* Persistent database storage
* Relationships between archive entires
* Advanced filtering and search.
* Recommendation functionality.
* Media Attachments and references.