using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared.Airtable;



namespace web_test_blazer_server.Shared._Site
{
	public partial class N_SectionItem
    {
        [Parameter]
        public SectionData Record { get; set; } = new();
    }
}

