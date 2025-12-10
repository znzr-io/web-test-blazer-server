using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared.Airtable;



namespace web_test_blazer_server.Shared._Site
{
	public partial class C_AgendaSection
    {
        [Parameter]
        public TableAgenda Records { get; set; } = new();

        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        public C_AgendaSection()
        {
            Class = "section-agenda";
        }
    }
}

