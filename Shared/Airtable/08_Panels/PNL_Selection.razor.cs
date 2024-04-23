using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;


namespace web_test_blazer_server.Shared.Airtable
{
	public partial class PNL_Selection
    {
        public PNL_Selection()
        {
            SelectedTab = "variables";
            PanelName = "selection";
        }

        protected Task OnSelectedTabChanged(string name)
        {
            SelectedTab = name;

            return Task.CompletedTask;
        }
    }
}