using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class Bookmark
    {
        [Parameter]
        public string Id { get; set; } = "Id";

        [Parameter]
        public string Label { get; set; } = "bookmark";

        [Parameter]
        public SelectionType TypeBookmark { get; set; }

        [Parameter]
        public bool AllowRemoveBookmark { get; set; }

        [Parameter]
        public bool HasNewItem { get; set; }
    }
}