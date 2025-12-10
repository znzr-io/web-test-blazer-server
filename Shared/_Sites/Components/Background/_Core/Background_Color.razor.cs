using System;
using AirtableApiClient;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared.Airtable;



namespace web_test_blazer_server.Shared._Site
{
	public partial class Background_Color
    {
		[Parameter]
		public string? Id { get; set; }

		[Parameter]
		public string? Class { get; set; }

        [Parameter]
        public AirtableRecord<ColorsData> Record { get; set; } = new();



		public string BackgroundColor()
		{
            return Air.Table.colors.CssBackgroundColor(Record.Fields);
		}
	}
}