using System;
using AirtableApiClient;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;

namespace web_test_blazer_server.Shared._Core
{
	public partial class TestWidget
	{
        [Parameter]
        public string? Name { get; set; }

        [Parameter]
        public string? Down { get; set; }

        [Parameter]
        public string? Up { get; set; }

        public TestWidget()
		{
		}

        private void SentUpwards(string msg)
        {
            //Up = msg + Airtable.Tables.agenda[2].Fields.Location;
        }
    }
}