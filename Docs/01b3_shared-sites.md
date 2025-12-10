[← Project Overview](../README.md)

[← Detailed Project Overview](01__detailed.md)

---

## Shared/_Site: Public Website Layer

This is the site rendering layer that composes `Airtable` + `_Core` to create the public website.

---

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