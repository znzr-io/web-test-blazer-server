using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;

namespace web_test_blazer_server.Shared.Airtable
{
	public partial class Selector
    {
        Dropdown? dropdown;

        [Parameter]
        public SelectionType TypeSelection { get; set; }

        [Parameter]
        public IconName IconSelection { get; set; }

        [Parameter]
        public string Label { get; set; } = "label";

        public string SelectedItem { get; set; } = "first";

    }
}