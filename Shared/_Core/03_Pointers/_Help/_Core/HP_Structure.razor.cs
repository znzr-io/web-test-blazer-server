using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared._Editor
{
	public partial class HP_Structure
    {
        [Parameter]
        public string RootStructureMenuId { get; set; } = "none";

        [Parameter]
        public Dictionary<string, Dictionary<string, Pointer_Service.Pointer>> AllPointers { get; set; } = new();

        public KeyValuePair<string, Dictionary<string, Pointer_Service.Pointer>> Entry { get; set; } = new();

        KeyValuePair<string, Dictionary<string, Pointer_Service.Pointer>> EntryValue { get; set; } = new();
    }
}