using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class RowNew
    {
        public async Task OnInvoke()
        {
            await LogHandle("NEW", "row is added", Color.Success);
        }
    }
}