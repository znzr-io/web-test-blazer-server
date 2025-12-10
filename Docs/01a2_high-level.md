[← Project Overview](../README.md)

[← Detailed Project Overview](01__detailed.md)

---

## High-Level Summary

---

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

[← Back to Project Overview](../README.md)
* [Detailed Documentation](Docs/01_detailed.md) (Docs/01_detailed.md)
  * [Review](Docs/01a0_review.md) (Docs/01a0_review.md)
  * [Architecture](Docs/01a1_architecture.md) (Docs/01a1_architecture.md)
  * [High-Level](Docs/01a2_high-level.md) (Docs/01a2_high-level.md)
  * [Shared/_Core](Docs/01b1_shared-core) (Docs/01b1_shared-core)
  * [Shared/_Editor](Docs/01b2_shared-editor.md) (Docs/01b2_shared-editor.md)
  * [Shared/_Sites](Docs/01b3_shared-sites.md) (Docs/01b3_shared-sites.md)
  * [Shared/Airtable](Docs/01b4_shared-airtable.md) (Docs/01b4_shared-airtable.md)
  * [Json](Docs/01b5_json.md) (Docs/01b5_json.md)
  * [Patterns](Docs/01c1_patterns.md) (Docs/01c1_patterns.md)
  * [Decisions](Docs/01c2_decisions.md) (Docs/01c2_decisions.md)
  * [Workflow](Docs/01c3_workflow.md) (Docs/01c3_workflow.md)
  * [Evolution](Docs/01c4_evolution.md) (Docs/01c4_evolution.md)
* [Data Drives UI](Docs/02_data-drives-ui.md) (Docs/02_data-drives-ui.md)
* [Airtable](Docs/03_airtable.md) (Docs/03_airtable.md)
* [Future Vision](Docs/04_vision.md) (Docs/04_vision.md)
  * [Architecture](Docs/04a1_architecture.md) (Docs/04a1_architecture.md)
  * [AI Integration](Docs/04a2_ai-integration.md) (Docs/04a2_ai-integration.md)
  * [Plugins](Docs/04a3_plugins.md) (Docs/04a3_plugins.md)
  * [Dynamic UI](Docs/04a4_dynamic-ui.md) (Docs/04a4_dynamic-ui.md)
  * [Automation](Docs/04a5_automation.md) (Docs/04a5_automation.md)
  * [Positioning](Docs/04b1_positioning.md) (Docs/04b1_positioning.md)
  * [Value](Docs/04b2_value.md) (Docs/04b2_value.md)
  * [Tech Specs](Docs/04c1_tech-specs.md) (Docs/04c1_tech-specs.md)
  * [Migration](Docs/04d1_migration.md) (Docs/04d1_migration.md)
* [AI Generated Code Review](Docs/05_review.md) (Docs/05_review.md)

---

to test the current state of the project: please request a key at:

**[arnold@znzr.io](mailto:arnold@znzr.io)**

---