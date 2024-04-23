using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class P_GroupTab
    {
        public override async Task OnInvoke()
        {
            LogDescription = "group is selected";
            await base.OnInvoke();
        }
    }
}