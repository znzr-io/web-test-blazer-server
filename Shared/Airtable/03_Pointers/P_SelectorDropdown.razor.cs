using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using static web_test_blazer_server.Shared._Core.CP_DropdownItem;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class P_SelectorDropdown
    {
        public override async Task NewItemSelected(IconLabelSet _item)
        {
            base.NewItemSelected(_item);

            await Task.CompletedTask;
        }
    }
}