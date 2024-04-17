using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared._Core
{
    public partial class FBase
    {

        [Parameter]
        public string Placeholder { get; set; } = "place";

        [Parameter]
        public string BadgeLabel { get; set; } = "label";

        public Color BadgeColor { get; set; } = Color.Dark;

        [Parameter]
        public string ToolTipText { get; set; } = "tooltip";
    }
}

