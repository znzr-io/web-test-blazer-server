using System;
using AirtableApiClient;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;

namespace web_test_blazer_server.Shared.Airtable
{
	public partial class InspectorHeader
    {
        [Parameter]
        public string Id { get; set; } = "ID";

        [Parameter]
        public string Label { get; set; } = "label";

    }
}