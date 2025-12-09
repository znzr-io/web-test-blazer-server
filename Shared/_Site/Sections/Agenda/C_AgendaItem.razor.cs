using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared.Airtable;



namespace web_test_blazer_server.Shared._Site
{
	public partial class C_AgendaItem
    {
        [Parameter]
        public AgendaData Record { get; set; } = new();

        /*
        [Parameter]
        public string? Type { get; set; }

        [Parameter]
        public string? NameFestival { get; set; }

        [Parameter]
        public string? Location { get; set; }

        [Parameter]
        public string? Date { get; set; }

        [Parameter]
        public string? Organizer { get; set; }

        [Parameter]
        public string? Link { get; set; }
        */
    }
}

