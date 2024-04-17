using System;
using AirtableApiClient;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;

namespace web_test_blazer_server.Shared.Airtable
{
	public partial class Tables
    {

        [Parameter]
        public string? Name { get; set; }

        [Parameter]
        public string? Down { get; set; }

        [Parameter]
        public string? Up { get; set; }

        [Parameter]
        public Dictionary<string, bool> Visible { get; set; } = new();

        public Tables()
		{
            
        }

        public Task OnBookmark()
        {
            return Task.CompletedTask;
        }
    }
}