[← Project Overview](../README.md)

[← Vision](04__vision.md)

---

## Plugin Architecture

---

### Plugin System Design

The framework uses a plugin-based architecture where each major UI element exists as a compiled DLL:

* View components
* Action handlers
* Widget implementations
* Panel layouts
* Input field types
* Validation logic
* Layout engines

### Rationale

This architecture provides several advantages:

* Child projects contain zero compiled code
* Version management becomes straightforward
* Features can be hot-swapped at runtime
* Platform extension doesn't require modifying core framework
* Different projects can use different plugin versions

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