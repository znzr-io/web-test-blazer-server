[← Project Overview](../README.md)

[← Detailed Project Overview](01__detailed.md)

---

## Shared/Airtable: Integration Layer

This is one of the most architecturally significant parts of the system.

---

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