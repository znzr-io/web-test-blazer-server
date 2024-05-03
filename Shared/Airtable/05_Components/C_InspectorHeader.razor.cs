using System;
using AirtableApiClient;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class C_InspectorHeader
    {
        [Parameter]
        public string Id { get; set; } = "ID";

        [Parameter]
        public string Label { get; set; } = "label";

    }
}