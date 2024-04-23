using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;


namespace web_test_blazer_server.Shared._Editor
{
	public partial class HP__Item
    {
        [Parameter]
        public Pointer_Service.Pointer Pointer { get; set; } = new();
    }
}