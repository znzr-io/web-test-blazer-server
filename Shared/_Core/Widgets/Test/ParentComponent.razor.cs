using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;



namespace web_test_blazer_server.Shared._Core
{
    public partial class ParentComponent
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        Color? badgeColor = Color.Dark;



        private void ChildSetParams(string _badgeLabel, Color _badgeColor, string _toolTipText)
        {
            BadgeLabel = _badgeLabel;
            BadgeColor = _badgeColor;
            ToolTipText = _toolTipText;
        }
    }
}

