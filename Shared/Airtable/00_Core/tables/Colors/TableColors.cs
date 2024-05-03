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
	public class TableColors : AirtableTable<ColorsData, ColorsService>
    {
        public TableColors()
        {
            fileName = "color";
            tableService = new();
            rows = new();
            Air.tables.TryAdd(fileName, this);
        }



        public override async Task GetTable()
        {
            await base.GetTable();

            /*
            Console.WriteLine(Table.colors[0].Fields.Name);
            Console.WriteLine(Table.colors[0].Fields.Hex);
            Console.WriteLine(Table.colors[0].Fields.R);
            Console.WriteLine(Table.colors[0].Fields.G);
            Console.WriteLine(Table.colors[0].Fields.B);
            Console.WriteLine(Table.colors[0].Fields.ImageIngredient);
            */
        }
    }
}