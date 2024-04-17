using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class VariableTabSelect
    {
        public override async Task OnInvoke()
        {
            await LogHandle(Label, "group is selected");
        }
    }
}