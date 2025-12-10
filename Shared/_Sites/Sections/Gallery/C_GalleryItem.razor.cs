using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared.Airtable;



namespace web_test_blazer_server.Shared._Site
{
	public partial class C_GalleryItem
    {
        [Parameter]
        public AirtableRecord<GalleryItemData> Record { get; set; } = new();
    }
}

