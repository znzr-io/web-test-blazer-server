using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared._Site;
using web_test_blazer_server.Shared.Airtable;



namespace web_test_blazer_server.Shared._Site
{
	public partial class C_Gallery
    {
        [Parameter]
        public GalleryData Record { get; set; } = new();

        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}