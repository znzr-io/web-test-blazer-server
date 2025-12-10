[← Project Overview](../README.md)

[← Vision](04__vision.md)

---

## System Architecture: Future State

---

### Detailed Architecture Flow
```
┌─────────────────────────────────────────────────────────────────────┐
│                          Azure Cloud                                │
│                                                                     │
│  ┌───────────────────────────────────────────────────────────────┐  │
│  │              Azure AI Search (Code Index)                     │  │
│  │  - Entire Blazor DSL / Components                             │  │
│  │  - Airtable/Cosmos Doc Schemas                                │  │
│  │  - Manuals, API Specs, Patterns                               │  │
│  │  - AI uses this for self-awareness                            │  │
│  └───────────────────────────────────────────────────────────────┘  │
└─────────────────────────────────────────────────────────────────────┘
                                |
                                | indexed knowledge
                                v
┌─────────────────────────────────────────────────────────────────────┐
│                      AI Reasoning Layer                             │
│─────────────────────────────────────────────────────────────────────│
│  - AI Foundry: structured JSON generation                           │
│  - Per-field AI augmentation                                        │
│  - Governance policies                                              │
│  - Automated layout & schema suggestions                            │
│  - Schema generation, UX rules, CI/CD orchestration                 │
└─────────────────────────────────────────────────────────────────────┘
                                |
                                | reads/writes schema
                                v
┌─────────────────────────────────────────────────────────────────────┐
│                    Dynamic Metadata Layer                           │
│─────────────────────────────────────────────────────────────────────│
│  Current: Airtable (Meta) API (phase-out planned)                   │
│  Future:  CosmosDB                                                  │
│                                                                     │
│  Schema Definitions:                                                │
│  - Dynamic JSON schema definitions                                  │
│  - Field-level config: type, UI rule, AI rule, governance           │
│  - View-level config: layout, structure, user roles                 │
│  - Table relationships & references                                 │
│  - CI/CD rules, loading, rendering configuration                    │
│                                                                     │
│  Result: JSON schema -> UI + rules + relationships                  │
└─────────────────────────────────────────────────────────────────────┘
                                |
                                | generates fully dynamic UI
                                v
┌─────────────────────────────────────────────────────────────────────┐
│                     Blazor Plugin System                            │
│─────────────────────────────────────────────────────────────────────│
│  Modular .DLL Components:                                           │
│  - Widgets, views, fields, smart inputs, validators                 │
│  - Editor components auto-generated from schema                     │
│  - Views, Panels, Widgets, Inputs generated programmatically        │
│  - No hardcoded UI; everything parsed from metadata                 │
│  - Tailwind CSS theming per project                                 │
│                                                                     │
│  Framework Principle:                                               │
│  - "Umbrella" framework: child projects = zero code                 │
│  - Only JSON config + theme required                                │
└─────────────────────────────────────────────────────────────────────┘
                                |
                                | serves UI
                                v
┌─────────────────────────────────────────────────────────────────────┐
│            Secure Local & Cloud Admin UIs (Blazor)                  │
│─────────────────────────────────────────────────────────────────────│
│  Local Admin (High Security):                                       │
│  - Azure API Auth                                                   │
│  - Schema editing / tooling                                         │
│  - Infrastructure management                                        │
│  - Secure schema and deployment management                          │
│                                                                     │
│  Cloud Admin (Online):                                              │
│  - Project-specific configuration                                   │
│  - Domain linking                                                   │
│  - Web app/container creation                                       │
│  - CI/CD automation                                                 │
└─────────────────────────────────────────────────────────────────────┘
                                |
                                | publishes static output / runtime assets
                                v
┌─────────────────────────────────────────────────────────────────────┐
│                  CDN + Static Delivery Layer                        │
│─────────────────────────────────────────────────────────────────────│
│  - Static CSS (Tailwind theme per project)                          │
│  - Pre-rendered JSON structure caches                               │
│  - Static JSON, media, styles, themes                               │
│  - Media assets                                                     │
│  - Edge hosting for speed                                           │
└─────────────────────────────────────────────────────────────────────┘
                                |
                                | consumed by minimal child projects
                                v
┌─────────────────────────────────────────────────────────────────────┐
│                   Child Projects (Zero-Code)                        │
│─────────────────────────────────────────────────────────────────────│
│  Project Structure:                                                 │
│  - Provide JSON schemas + Airtable/Cosmos data                      │
│  - Optional Tailwind theme overrides                                │
│  - Framework generates entire UI automatically                      │
│  - No local logic - only metadata                                   │
│                                                                     │
│  Result: Zero code, zero duplication                                │
└─────────────────────────────────────────────────────────────────────┘
```

### Simplified Architecture View
```
Azure Cloud
    |
    v
Azure AI Search Layer
(Framework code, plugins, schemas, documentation)
    |
    v
AI Reasoning Layer
(Schema generation, UX rules, CI/CD, governance)
    |
    v
Dynamic Metadata Layer (Cosmos)
(JSON schema -> UI + rules + relationships)
    |
    v
Blazor Plugin System
(Widgets, views, fields, smart inputs, validators)
    |
    v
Admin UIs (Local and Cloud)
(Secure schema and deployment management)
    |
    v
CDN Delivery Layer
(Static JSON, media, styles, themes)
    |
    v
Child Projects (Zero-Code)
(Only schema + theme configuration)
```

### Key Architecture Principles

**Top-Down Flow:**
1. Azure AI Search provides comprehensive knowledge base
2. AI Reasoning generates and validates schemas
3. Dynamic Metadata defines all UI and business logic
4. Plugin System renders everything programmatically
5. Admin UIs manage configuration and deployment
6. CDN delivers static assets efficiently
7. Child Projects contain only configuration

**Zero-Code Child Projects:**
- No compiled code
- Only JSON schema + Tailwind theme
- Everything else auto-generated
- Framework handles all UI rendering
- Consistent behavior across projects

**Migration Path:**
- Current: Airtable for metadata
- Future: CosmosDB for metadata
- Existing codebase validates the architecture
- Clean extraction path to plugin system
- Curent: blazorize for UI elements
- Future: tailwindcss for UI theming

Key architectural characteristics:

* Azure AI Search provides comprehensive indexing of all framework artifacts
* AI reasoning layer handles schema generation, governance, and deployment orchestration
* Dynamic metadata in CosmosDB drives all UI and business logic
* Plugin system provides extensibility without core framework modification
* Secure admin interfaces for schema and deployment management
* CDN layer for static asset delivery and performance

Child projects contain only schema and theme configuration. Everything else is generated.

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