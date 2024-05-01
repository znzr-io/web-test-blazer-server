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
	public class AppsService : AirtableTableService<AppsData>
	{
        public AppsService()
        {
            TABLE_ID = "tblrBLrTvuoMjBKey";
            offset = "";
            fields = new() { "Name", "Workspaces", "Icon", "Notes" };
            filterByFormula = "";
            maxRecords = 1000;
            pageSize = 1;
            //sort;
        }
    }
}