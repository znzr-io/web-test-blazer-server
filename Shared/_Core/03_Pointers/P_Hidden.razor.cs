using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared._Core
{
	public partial class P_Hidden
    {
        public override async Task OnInvoke()
        {
            LogDescription = "hidden";

            await base.OnInvoke();
        }
    }
}