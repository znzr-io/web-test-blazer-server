using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;


namespace web_test_blazer_server.Shared._Editor
{
	public partial class HP_CurrentPath
    {
        [Parameter]
        public List<Pointer_Service.Pointer> CurrentPath { get; set; } = new();

        [Parameter]
        public string PathDepth { get; set; } = "";
    }
}