using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using AirtableApiClient;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Buffers.Text;



namespace web_test_blazer_server.Shared.Airtable
{
    public abstract class AirtableTable<TDATA, TSERVICE> : AirtableTableBase
        where TSERVICE : AirtableTableService<TDATA>
    {
        public TSERVICE? tableService;
        public List<AirtableRecord<TDATA>>? rows;



        public override async Task SerializeTable()
        {
            json = JsonSerializer.Serialize(rows);
            File.WriteAllText($"Json/{fileName}.json", json);

            await Task.CompletedTask;
        }



        public override async Task DeSerializeTable()
        {
            if (File.Exists($"Json/{fileName}.json"))
            {
                json = File.ReadAllText($"Json/{fileName}.json");
                rows = JsonSerializer.Deserialize<List<AirtableRecord<TDATA>>>(json);
            }

            await Task.CompletedTask;
        }



        public override async Task GetTable()
        {
            if(tableService != null)
                rows = await tableService.GetRecords();
        }
    }
}