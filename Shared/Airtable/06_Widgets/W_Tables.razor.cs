using System;
using AirtableApiClient;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;
using web_test_blazer_server.Shared._Editor;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class W_Tables
    {
        [Parameter]
        public Dictionary<string, bool> Visible { get; set; } = new();

        [Parameter]
        public string IdParentMenu { get; set; } = "";



        protected void ToggleAccordion(string item)
        {
            System.Console.WriteLine($"W_Tables.ToggleAccordion({item})");
            if (DataEditor.AccordionSingle == true)
                foreach (KeyValuePair<string, bool> entry in Visible)
                    Visible[entry.Key] = false;

            Visible[item] = true;
        }
    }
}