using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;


namespace web_test_blazer_server.Shared._Editor
{
    
	public partial class BaseView
    {
        [Parameter]
        public string Label { get; set; } = "-";

        [Parameter]
        public bool IsTabContent { get; set; }

        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter]
        public string IdMenuItem { get; set; } = "";
    }
}