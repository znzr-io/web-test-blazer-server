using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared.Editor;


namespace web_test_blazer_server.Shared.Airtable
{
	public partial class RowBookmark
    {
        public override async Task OnInvoke()
        {
            IconColor = Color.Light;
            IconColorBookMarked = Color.Success;
            IconColorNotBookMarked = Color.Light;
            LogDescription = "row is bookmarked";
            TypeBookmark = SelectionType.row;
            await base.OnInvoke();
        }
    }
}