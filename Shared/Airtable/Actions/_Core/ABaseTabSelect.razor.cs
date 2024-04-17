using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class ABaseTabSelect
    {
        [Parameter]
        public string Id { get; set; } = "logID";

        [Parameter]
        public string ToolTip { get; set; } = "label";

        [Parameter]
        public TextColor IconColor { get; set; } = TextColor.Default;

        [Parameter]
        public IconName IconsName { get; set; }

        [Parameter]
        public Background BackgroundColor { get; set; } = Background.Default;
    }
}