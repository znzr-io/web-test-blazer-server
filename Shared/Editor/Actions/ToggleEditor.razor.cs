using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;


namespace web_test_blazer_server.Shared.Editor
{
	public partial class ToggleEditor
    {
        IconName icon = IconName.Star;

        public async Task OnInvoke()
        {
            await LogHandle("EDITOR", "toggle");
        }
    }
}