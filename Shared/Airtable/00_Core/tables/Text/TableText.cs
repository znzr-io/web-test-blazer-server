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
	public class TableText : AirtableTable<TextData, TextService>
    {
        public TableText()
        {
            fileName = "text";
            tableService = new();
            rows = new();
            Air.tables.TryAdd(fileName, this);
        }



        public override async Task GetTable()
        {
            await base.GetTable();

            /*
            var t = Table.text.SingleOrDefault(t => t.Fields.Name == "txt-button-about");
            Console.WriteLine("TEXT.txt-button-about: " + t.Fields.En);
            */
        }



        public string Get(string textField)
        {
            return Get(textField, "En");
        }



        public string Get(string textField, string lang)
        {
            string result = "null";

            if(rows != null)
            {
                var p = rows.SingleOrDefault(t => t.Fields.Name == textField);

                if (p != null && lang != null && p.Fields.GetProperty(lang) != null)
                {
                    var s = p.Fields.GetProperty(lang);
                    if(s != null)
                        result = (string)s;
                }  
            }

            return result;
        }
    }
}