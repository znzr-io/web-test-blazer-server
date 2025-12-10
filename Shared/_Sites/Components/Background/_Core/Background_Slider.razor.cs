using System;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared.Airtable;

namespace web_test_blazer_server.Shared._Site
{
	public partial class Background_Slider
    {
		[Parameter]
		public string? Id { get; set; }

		[Parameter]
		public string? Class { get; set; }



        private string BackgroundColor()
        {
            string r = "";
            //string bgColor = Air.Table.colors.CssBackgroundColor(Record.Fields.BackgroundColor[0]);

            //if (bgColor != null && bgColor != "")
            //    r = bgColor;

            return r;
        }
    }
}

