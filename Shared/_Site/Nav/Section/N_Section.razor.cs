using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared.Airtable;



namespace web_test_blazer_server.Shared._Site
{
	public partial class N_Section
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}

