using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;

namespace web_test_blazer_server.Shared.Airtable
{
	public partial class Structure
    {
        Dropdown? dropdown;

        string selectedTab = "content";

        private Task OnSelectedTabChanged(string name)
        {
            selectedTab = name;

            return Task.CompletedTask;
        }



        [Parameter]
        public string? Name { get; set; }

        [Parameter]
        public string? Down { get; set; }

        [Parameter]
        public string? Up { get; set; }



        private void SentUpwards(string msg)
        {
            //Up = msg + Airtable.Tables.agenda[2].Fields.Location;
        }

        

        Task ShowMenu()
        {
            return dropdown.Show();
        }


        public Task OnBookmarkSelect()
        {
            return Task.CompletedTask;
        }



        public Task OnViewControls()
        {
            return Task.CompletedTask;
        }



        public Task OnViewBoth()
        {
            return Task.CompletedTask;
        }



        public Task OnViewStructure()
        {
            return Task.CompletedTask;
        }


    }
}