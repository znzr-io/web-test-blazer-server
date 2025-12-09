[← Back to Project Overview](../README.md)

---

# Airtable Overview

---

1. **What Airtable Is**  
   A hybrid between a spreadsheet and a relationaldatabase. Easy for non-technical users, powerful enough for developers via its REST API and metadata structure.
---
2. **Base**  
   A top-level container (like a database). Holds tables, automations, views, extensions. Each base has an ID like `appXXXXXXXXXXXX`.
---
3. **Tables**  
   Equivalent to DB tables or sheets. Each table contains fields (columns) and records (rows). Tables define the schema and relationships.
---
4. **Fields**  
   Typed columns. Common types: text, long text, number, select, linked record, attachment, rollup, lookup, formula, checkbox, date, URL. Field config is crucial for schema-driven UI.
---
5. **Records**  
   Rows inside a table. Each record has an ID (`recXXXX`) and field/value pairs. Attachments and linked records are arrays. Records come back via the API as `{ id, fields }`.
---
6. **Views**  
   Saved configurations for filtering, sorting, and grouping. API queries can target a view to only return filtered records: `?view=MyView`.
---
7. **Relationships**  
   Done with *Linked Record* fields. These create relationships like one-to-many or many-to-many, enabling reference graphs similar to relational DBs.
---
8. **Automations**  
   Event-driven workflows. Trigger types: record created/updated, condition match, schedule, webhook. Actions: update/create record, send requests, run JavaScript, branch logic.
---
9. **API**  
   Simple REST API:  
   - `GET /v0/{baseId}/{table}` – list records  
   - `POST /v0/{baseId}/{table}` – create  
   - `PATCH /v0/{baseId}/{table}/{id}` – update  
   Uses Bearer tokens. Batch writes allow up to 10 records per request.

---

10. **SDKs (Node.js & C#)**  
    Airtable provides official JS tooling and the community uses Airtable.NET for C#.

    **Node.js SDK:**
    ```js
    const Airtable = require('airtable');
    const base = new Airtable({ apiKey }).base('appXXXX');
    base('Pages').select().eachPage((records, next) => next());
    ```

    **C# SDK (Airtable.NET):**  
    [Airtable.NET GitHub](https://github.com/ngocnicholas/airtable.net)
    ```csharp
    var client = new AirtableBase("YOUR_API_KEY", "appXXXX");
    var response = await client.ListRecords("Pages");
    ```

---

more info: [airtable.com](https://airtable.com)

---

[← Back to Project Overview](../README.md)
* [Detailed Documentation](Docs/01_detailed.md) (Docs/01_detailed.md)
* [Data Drives UI](Docs/02_data-drives-ui.md) (Docs/02_data-drives-ui.md)
* [Airtable](Docs/03_airtable.md) (Docs/03_airtable.md)
* [Future Vision](Docs/04_vision.md) (Docs/04_vision.md)
* [AI Generated Code Review](Docs/05_review.md) (Docs/05_review.md)

---

to test the current state of the project: please request a key at:

**[arnold@znzr.io](mailto:arnold@znzr.io)**

---

