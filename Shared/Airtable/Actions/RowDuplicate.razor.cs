using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class RowDuplicate
    {
        [Parameter]
        public string Id { get; set; } = "logID";



        public async Task OnInvoke()
        {
            await LogHandle(Id, "row is duplicated", Color.Success);
        }
    }
}