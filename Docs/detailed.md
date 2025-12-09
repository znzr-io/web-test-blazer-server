# Detailed Project Overview

Technical Documentation and Project Context

---

[← Back to Documentation Index](../index.md)

---

### Overview

The existing system is a Blazor Server application with two primary components:

1. Content-driven public websites built from Airtable or JSON data sources (already reads from the json)
2. An internal editor that enables browsing and editing of Airtable schema and data (all elements created, but not connected to the json loop)

### Code Organization

The codebase follows a layered architecture:

```
Shared/
├── _Core          - foundational framework components
├── _Editor        - editor UI implementation
├── Airtable       - Airtable integration and JSON caching layer
└── _Site          - site sections (Welcome, Gallery, Agenda, etc.)
```

I write clean, maintainable code. For personal projects I sometimes use custom naming conventions (documented here) to speed up development. In team environments, I happily follow the agreed-upon coding standards.

### Key Technical Concepts

The system implements several core patterns:

* Components organized by a consistent numbering convention (00_Core through 08_Panels)
* Pointer-based state management for efficient data handling
* Three-stage sync pipeline: Airtable to JSON cache to UI
* Section structure using SectionBase with CW_Section wrapper components
* Editor UI generated dynamically from Airtable metadata

---

## Architectural Rationale

### Original Design Goals

When I started this project, I had several objectives:

* Learn Blazor deeply through practical implementation
* Find an architecture that would allow me to easely expand with already made Unity3d classes
* Build genuinely reusable primitives rather than one-off components
* Enable dynamic content rendering without hardcoded layouts
* Create both a public site and an admin editor sharing a single framework
* Establish modular structure ready for future expansion
* Have AIRTABLE working as a plugin inside a bigger system

### Achieved Results

The current implementation delivers on these goals:

* Editor components are fully reusable across different contexts
* Site and Editor share the same foundation code
* Airtable schema directly drives UI generation
* JSON caching layer provides offline capability and performance
* Clear separation between data layer, UI layer, and rendering logic
* Unity3d code can be used as well, with some minor tweaking as Blazor doesnt use Monobehaviours

This architecture proved the viability of schema-driven UI generation and became the foundation for a larger vision.

---

## Technical Lessons and Evolution

### Implementation Insights

Several technical patterns emerged as particularly effective:

* The static Air class serves its purpose but would benefit from proper dependency injection in a production refactor
* Editor and UI components can be dynamically generated from metadata alone
* Schema-driven rendering provides both power and maintainability
* The codebase structure naturally supports modularization into plugin DLLs

### Architectural Insights

The project validated several architectural principles:

* A clear component numbering pattern (00_Core through 08_Panels) scales well as complexity grows
* Metadata-driven systems dramatically reduce code duplication
* This type of system architecture benefits significantly from AI integration
* The line between "configuration" and "code" can be productively blurred

---

## System Architecture Diagram
```
Program.cs (Startup)
  |
  | - Configure AirtableSettings
  | - Register services
  | - Blazor Server setup
  |
  v
Pages
  |
  | - Index (renders website)
  | - Editor (renders editor UI)
  | - Test/demo pages (optional)
  |
  v
Shared/_Core
  |
  | - Pointer_Service
  | - Base classes, enums, events
  | - Display/Field/Action patterns
  | - Used by Editor + Site
  |
  +---> Shared/_Editor              +---> Shared/_Site
        |                                 |
        | Editor UI & Tools Layer         | Public Website Layer
        |                                 |
        | - EditorView_Service            | - SectionBase
        | - EditorVisibility_Service      | - Section wrappers
        | - LogCatcher_Service            | - Page assemblies
        | - Displays/Fields/Actions       | - Airtable content
        | - Panels/Views/Widgets          | - Welcome, Gallery, etc.
        |                                 |
        +----------------+----------------+
                         |
                         v
                  Shared/Airtable
                         |
                         | - Air (tables + config)
                         | - AirtableTableBase/Table
                         | - Table models (Settings, etc.)
                         | - Sync Actions (A_AirtableSync)
                         | - JSON serialization
                         |
                         v
                  Airtable API
                         |
                         | (sync, fetch, serialize)
```

---
## Modularity

The architecture implements orthogonal concerns across a layered foundation, where capabilities like governance, AI augmentation, and data generation can be independently applied to any layer without coupling

**ARCHITECTURE** (vertical micro -> macro)

| Folder / Module   | Description                                                        |
|-------------------|--------------------------------------------------------------------|
| `00_Core`         | System classes                                                     |
| `01_Displays`     | Read/output: text, images, Unity3D, etc.                           |
| `02_Fields`       | Read & write inputs (form fields, editors, etc.)                   |
| `03_Pointers`     | Interaction helpers: buttons, dropdowns, selectors, etc.           |
| `04_Actions`      | User & system actions / control logic                              |
| `05_Components`   | Layout composed of displays, fields, pointers, and actions         |
| `06_Widgets`      | Layout containers combining multiple views                         |
| `07_View`         | Layout definitions for single or multiple views                    |
| `08_Panels`       | Higher-level layout grouping multiple views                        |


**AIRTABLE STRUCTURE** (vertical)

| Layer             | Description                                                        |
|-------------------|--------------------------------------------------------------------|
| `Base`            | Project-level container                                            |
| `Table`           | Dataset made of rows & fields                                      |
| `Row`             | Individual record (instance)                                       |
| `Field`           | Typed value inside a row                                           |


**CONCERNS** (horizontal)
* `Governance policies`
* `AI augmentation`
* `Validation rules`
* `Governance policies`
* `Security policies`
* `CI/CD automation`
* `Data generation rules`
* `Etc...`

---




## High-Level Summary


### Overall Concept

This is a Blazor Server application that serves two purposes:

1. Renders a public-facing websites composed of reusable "sections" (Welcome, Agenda, Gallery, etc. Dynamicly generated from Airtable content)
2. Provides an Editor UI for exploring and manipulating Airtable-backed content (tables, rows, bookmarks (not fully implemented))

The system uses a custom internal design framework split into four component libraries:

* `_Core` - Generic framework building blocks
* `_Editor` - Editor-specific components and services
* `Airtable` - Airtable integration layer
* `_Site` - Public website implementation

Architecture flow:

```
Pages (Index, Editor)
    -> Shared._Site (renders public site)
        -> Shared.Airtable + Json (content sources)
            -> Shared._Editor + services (editor state management)
```

---

## Project Structure

### Root-Level Files

**Program.cs**

Standard ASP.NET Core / Blazor Server bootstrapping that:

* Creates the WebApplication builder
* Registers Blazorise (Bootstrap5 + FontAwesome)
* Registers application-specific services:
    * MainNavMenuService
    * EditorView_Service
    * EditorVisibility_Service
    * Pointer_Service
    * LogCatcher_Service
    * AirtableTableService, SettingsService, etc.
* Configures middleware (UseStaticFiles, routing, BlazorHub, _Host fallback)

**App.razor**

Standard Blazor app shell containing Router, CascadingAuthenticationState, Layout components.

**Project Files**

* `web-test-blazer-server.csproj` and `.sln` - Single Blazor Server project with no separate test project

### Main Directories

* `Pages/` - Razor pages that are navigable routes
* `Shared/` - The bulk of the codebase: reusable components and services
* `Data/` - Basic data classes and navigation data
* `Json/` - Serialized Airtable data stored as JSON
* `Design/` - Simple utilities (icon handling)
* `wwwroot/` - Static assets (CSS, JS, etc.)

---

## Pages: Navigable Routes

### Index.razor

* Route: `/`
* Uses `<PNL_Website />` (from Shared._Core / _Site) to render the main site
* Contains a button linking to `/editor`

### Editor.razor + Editor.razor.cs

* Route: `/editor`
* Injected dependencies:
    * EditorView_Service
    * EditorVisibility_Service
    * IJSRuntime
    * NavigationManager

Key functionality:

* Defines `EditorSplitView` enum for managing top/center/bottom views
* Logic to manage split panes, toggle visibility, and adjust heights (editorUpperSplitViewTop/Center/Bottom)
* In `OnInitializedAsync`:
    * Deserializes Airtable tables via `Air.DeSerializeTables()`
    * Subscribes to view/visibility events from services
* `OnAfterRenderAsync`:
    * Imports JavaScript (`../js/webflow/webflow.js`)
    * Updates on navigation changes

### Template Pages

* `Counter.razor`, `FetchData.razor`, `TestPage.razor` and their `.cs` code-behind files
* Mostly template/demo pages demonstrating standard Blazor patterns

### Standard Pages

* `_Host.cshtml` - Standard Blazor host page
* `Error.cshtml` - Error handling page



## Design System Utilities

### Design/Icons.cs

Minimal design system utility for icon handling:

```csharp
enum Icons { home, plus, volume_high, command }

static class Icon {
    Convert(string icon) -> "oi-" + icon.Replace('_','-')
}
```

Maps strongly-typed enums to CSS icon class names. This is a lightweight utility that could be expanded into a more comprehensive design system.

---

## Shared/_Core: Generic Framework Layer

`Shared/_Core` contains generic component framework building blocks used by both Editor and Site.

### Organization Pattern

The folder structure follows a consistent numbering convention (highlevel -> lowlevel):

```
00_Core/
01_Displays/
02_Fields/
03_Pointers/
04_Actions/
05_Components/
06_Widgets/
07_View/
08_Panels/

```

This pattern repeats across `_Core`, `_Editor`, `Airtable`, and `_Site` layers.

### 00_Core/

**Enums/StateVisibility.cs**

Defines visibility states for UI elements.

**Events/Pointer_Service.cs**

* Manages the current "pointer" (selection) in the editor/site
* Raises `ServiceAction` event when the pointer changes
* Central service for coordinating which table/row/field is currently selected

### Layer Responsibilities

* **01_Displays** - Basic visual elements
* **02_Fields** - Form inputs and data fields
* **03_Pointers** - Selection/targeting components
* **04_Actions** - Buttons and actionable components
* **05_Components** - Mid-level compositions
* **06_Widgets** - Higher-level UI assemblies
* **07_View** - Large screens and layouts
* **08_Panels** - Final UI panels and application-level assemblies

`_Core` provides the generic building blocks used by both the Editor and the Site, ensuring consistent patterns and reusable abstractions.

---

## Shared/_Editor: Editor Framework

`Shared/_Editor` is the editor framework layer built on top of `_Core`.

### 00_Core/Events/

**LogCatcher_Service.cs**

* Service that stores message/description/color
* Raises `LogCatched` event
* Used to display logs to the user (e.g., during Airtable sync operations)

**EditorView_Service.cs**

* Maintains current `EditorSplitView` state
* Manages `APreBase_EditorView` toggles
* Raises `EditorViewToggled` event for UI coordination

### 07_View/_Core/

**BaseView.razor + BaseView.razor.cs**

Base component for editor views with parameters:

* Label
* IsTabContent
* ChildContent
* IdMenuItem

Used as foundation for specific views like `V_Workspace` in the Airtable layer.

### Component Conventions

Editor components use consistent prefixes:

* `APreBase_...` - Abstract/pre-base view models and templates
* Editor-specific UI panels, tabs, and controls

The Editor page (`Pages/Editor.razor.cs`) leverages these services and base components to manage layout and UI behavior dynamically.

---

## Shared/Airtable: Integration Layer

This is one of the most architecturally significant parts of the system.

### Core Classes

Located in `Shared/Airtable/00_Core/_Core`:

**Airtable.cs**

Static `Air` class serving as central Airtable coordinator:

* Holds hard-coded `BASE_ID` and API key
* Maintains `Dictionary<string, AirtableTableBase> tables`
* Nested static `Table` class with table objects:
    * TableApps
    * TableWorkspaces
    * TableTables
    * TableMediaCollectionContent
    * etc.

**AirtableTableBase.cs / AirtableTable.cs**

Abstractions around an Airtable table providing:

* `GetTable()` - Read data from Airtable via `AirtableApiClient`
* `SerializeTable()` / `DeSerializeTable()` - Handle saving/loading data to/from `Json/` folder

**AirtableVarAsStringExtention.cs**

Helper methods to convert Airtable values to strings and other common transformations.

**AirtableTableService.cs**

Service layer for interacting with Airtable tables, providing a clean interface to the rest of the application.

### Strongly-Typed Table Definitions

Located in `Tables/`:

* `TableSettings.cs`, `SettingsService.cs`
* Each table has its own strongly-typed representation
* Services provide typed access to table data

### UI Layer Components

**01_Displays, 02_Fields, 03_Pointers**

Components representing Airtable entities:

* `P_Table` - Table pointer/selector
* `P_Row` - Row pointer/selector
* `P_Field` - Field pointer/selector

**04_Actions**

**A_AirtableSync.razor + A_AirtableSync.razor.cs**

Handles "Sync Airtable" action with upload and download:

* Uses `LogCatcher_Service` to show progress:
    * "Uploading"
    * "Downloading"
    * "[current/total] {fileName}"
    * "done!"
* Iterates through `Air.tables` and calls:
    * `GetTable()` - Fetch from Airtable
    * `SerializeTable()` - Save to JSON
* Uses `PagesStatic.ChangeState()` to trigger UI refresh

Other actions include:

* New row
* Duplicate row
* Delete row
* Bookmark row/table
* Search functionality

**06_Widgets**

**W_Tables.razor + W_Tables.razor.cs**

Widget for listing and selecting tables in the editor.

**07_View**

**V_Workspace.razor + V_Workspace.razor.cs**

* Inherits from `BaseView`
* Composes tables widget in a tab panel
* Primary workspace view in the editor

**08_Panels**

* `PNL_Selection` - Shows current selection details
* `PNL_Structure` - Displays structure information

### Summary

The Airtable layer functions as a small Airtable client framework built on top of `AirtableApiClient`, providing:

* Blazor UI for browsing and editing tables
* Local JSON caching for offline and performance
* Strongly-typed access to table data
* Synchronization utilities

---

## Shared/_Site: Public Website Layer

This is the site rendering layer that composes `Airtable` + `_Core` to create the public website.

### Layouts

**Layouts/MainLayout.razor**

Overall site layout structure:

* Header
* Navigation
* Body content area

### Navigation

**Nav/MainPages**

Top-level page navigation.

**Nav/Section**

Section-level navigation within pages.

### Pages

**Pages/PAGE_Home.razor**

Assembles the home page by composing multiple sections.

### Section Architecture

**Sections/_Core/Base/SectionBase.razor + SectionBase.razor.cs**

Base class for all sections with properties:

* `Id` - Section identifier
* `Class` - CSS classes
* `Section` - `SectionData` object from Airtable/Json

**Sections/_Core/Wrappers/CW_Section.razor + CW_Section.razor.cs**

Wrapper component that:

* Accepts `Id`, `Class`, and `Section` parameters
* Renders section content within a consistent shell
* Provides common styling and layout

### Concrete Sections

Located in `Sections/`:

* `Welcome/`
* `Agenda/`
* `Contact/`
* `Gallery/`
* etc.

Each section follows the pattern:

```csharp
@inherits SectionBase

// Renders inside <CW_Section ...>
```

Example structure:

* `C_WelcomeSection.razor`
* Inherits from `SectionBase`
* Calls `base.BuildRenderTree(__builder)`
* Renders unique content inside `<CW_Section>`

This gives each section:

* Consistent layout via wrapper
* Unique content implementation
* Data from Airtable/Json
* Shared styling and behavior

The site is composed entirely of section components, all following this uniform pattern, making it easy to add, remove, or reorder sections without touching layout code.

---

## Json Folder: Local Data Cache

The `Json/` directory contains JSON files mirroring Airtable tables (downloaded from Airtable via the API).:

* `settings.json`, `settingsJson.json`
* `sections.json`, `sectionsJson.json`
* `tables.json`, `tablesJson.json`
* `agenda.json`, `agendaJson.json`
* etc.

### Purpose

These JSON files provide:

* **Caching** - Local storage of Airtable content
* **Performance** - Eliminates API calls on every page load
* **Offline capability** - Site can run without Airtable connectivity
* **Development speed** - Faster iteration during development
* **API rate limiting** - Reduces API calls to Airtable

The cache is synchronized via the Editor UI's Airtable Sync utility, giving manual control over when fresh data is fetched.

---

## Key Architectural Patterns

### Layered Separation

The four-layer structure (`_Core`, `_Editor`, `_Site`, `Airtable`) provides:

* Clear boundaries between concerns
* Reusability of components across contexts
* Independent testing and development of layers
* Clean migration path for future changes
* Starting with _ (`_Core`, `_Editor`, `_Site`) system
* Without _ (`Airtable`) plugin(s)

### Numbered Folder Convention

The 00-08 folder pattern creates:

* Self-documenting file organization
* Predictable component locations
* Clear dependency hierarchy (lower numbers have fewer dependencies)
* Consistent structure across all layers

### Component Prefix System

Prefixes (`A_`, `C_`, `W_`, `V_`, `PNL_`, `P_`) provide:

* Instant recognition of component role
* Clear mental model of component hierarchy
* Easy navigation through the codebase
* Consistent naming across the application

### Component Prefix legenda
* `D_` : Displays
* `F_` : Field
* `P_` : Pointers
* `A_` : Actions
* `C_` : Components
* `W_` : Widgets
* `V_` : Views
* `PNL_` : Panels

### Section-Based Website

The section pattern enables:

* Reusable, modular content blocks
* Data-driven page composition
* Consistent styling via wrappers
* Easy addition/removal of content sections

---

## Technical Decisions and Rationale

### Why Static `Air` Class

The static `Air` class centralizes Airtable configuration and table references. While this could evolve into dependency injection in a production refactor, it provides:

* Single source of truth for table definitions
* Easy access from anywhere in the application
* Simple initialization and coordination

### Why JSON Caching

Local JSON caching addresses several concerns:

* Airtable API rate limits
* Performance for repeated page loads
* Offline development and testing
* Faster user experience

### Why Service-Based Architecture

Services like `Pointer_Service`, `EditorView_Service`, and `LogCatcher_Service` provide:

* Decoupled communication between components
* Event-driven state management
* Testable business logic
* Clear separation between UI and logic

---

## Development Workflow

### Typical Workflow

1. Define or modify content structure in Airtable
2. Open Editor UI in browser
3. Click "Sync Airtable" button
4. JSON cache updates in `Json/` folder
5. Application automatically reflects changes
6. Site sections render updated content

### Editor Capabilities

The Editor provides:

* Real-time Airtable schema browsing (not fully implemented)
* Row and field inspection (not fully implemented)
* Pointer-based navigation between entities
* Logging output for debugging sync operations
* Manual synchronization control

---

## Future Evolution

This architecture serves as a foundation for potential enhancements:

### Near-Term Possibilities

* AI-assisted content generation
* Automated UI generation from schema metadata
* Multi-tenant deployment capabilities
* Plugin DLL architecture for components
* Dynamic plugin loading at runtime
* Enhanced caching & loading strategies
    * data & dll load on specific moments in user journey
        * AppLoad
        * PageLoad,
        * WidgetLoad,
        * FieldUpdate,
        * RealtimeStreaming
        * etc...

### Long-Term Vision

* Extraction of layers into NuGet packages
* Migration from Airtable to CosmosDB


The current structure supports these evolutions without requiring fundamental architectural rewrites.

---

[← Back to Documentation Index](../index.md)

---

