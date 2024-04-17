using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class TableBookmark
    {
        public override async Task OnInvoke()
        {
            IconColor = Color.Light;
            IconColorBookMarked = Color.Primary;
            IconColorNotBookMarked = Color.Light;
            LogDescription = "table is bookmarked";
            TypeBookmark = SelectionType.table;
            await base.OnInvoke();
        }
    }
}