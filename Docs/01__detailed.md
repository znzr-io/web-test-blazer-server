[← Back to Project Overview](../README.md)

---

# Detailed Project Overview

Technical Documentation and Project Context

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
