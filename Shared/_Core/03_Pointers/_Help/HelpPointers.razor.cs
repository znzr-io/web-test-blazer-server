using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;



namespace web_test_blazer_server.Shared._Editor
{
	public partial class HelpPointers
    {
        protected override async Task OnInitializedAsync()
        {
            pointerS.ServiceAction += StateHasChanged;
            await Task.CompletedTask;
        }



        public void Dispose()
        {
            pointerS.ServiceAction -= StateHasChanged;
        }
    }
}