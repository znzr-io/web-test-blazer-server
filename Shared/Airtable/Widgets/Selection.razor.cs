using System;
using AirtableApiClient;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;

namespace web_test_blazer_server.Shared.Airtable
{
	public partial class Selection
    {
        string selectedTab = "text";

        [Parameter]
        public SelectionType TypeSelection { get; set; } = SelectionType.group;



        private Task OnSelectedTabChanged(string name)
        {
            selectedTab = name;
            
            return Task.CompletedTask;
        }
    }
}