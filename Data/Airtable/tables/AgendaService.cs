using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using AirtableApiClient;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Buffers.Text;



namespace web_test_blazer_server.Data.Airtable
{
	public class AgendaService : AirtableTableService<AgendaData>
	{
        public AgendaService()
        {
            TABLE_ID = "tblKyJHPXmdqoeH4N";
            offset = "";
            fields = new() { "Name", "Publish", "Location", "DateFrom", "DateTill", "Organizer", "Type", "Notes" };
            filterByFormula = "";
            maxRecords = 100;
            pageSize = 1;
            //sort;
        }
    }
}