using System;
using AirtableApiClient;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;

namespace web_test_blazer_server.Shared.Airtable
{
	public partial class Rows
    {

        [Parameter]
        public string? Name { get; set; }



        



        public Task OnSelect()
        {
            return Task.CompletedTask;
        }



        public Task OnDelete()
        {
            return Task.CompletedTask;
        }



        public Task OnDuplicate()
        {
            return Task.CompletedTask;
        }



        public Task OnNewRow()
        {
            return Task.CompletedTask;
        }
    }
}