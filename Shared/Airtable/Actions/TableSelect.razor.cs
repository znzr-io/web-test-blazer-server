using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class TableSelect
    {
        [Parameter]
        public string? Label { get; set; }



        public async Task OnInvoke()
        {
            await LogHandle("TABLE", $"{Label} is selected");
        }
    }
}