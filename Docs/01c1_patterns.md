[← Project Overview](../README.md)

[← Detailed Project Overview](01__detailed.md)

---

## Key Architectural Patterns

---

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