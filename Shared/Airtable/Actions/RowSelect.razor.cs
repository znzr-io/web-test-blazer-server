using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class RowSelect
    {
        [Parameter]
        public string Id { get; set; } = "logID";

        [Parameter]
        public string Label { get; set; } = "logID";

        [Parameter]
        public Color ColorSelector { get; set; } = Color.Light;



        public async Task OnInvoke()
        {
            await LogHandle(Id, "row is selected");
        }
    }
}