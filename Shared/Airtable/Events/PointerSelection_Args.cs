using System;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Airtable
{
	public class PointerSelection_Args : EventArgs
	{
        public string IdRecord { get; set; } = "row id";

        public string IdRow { get; set; } = "row id";

        public string IdTable { get; set; } = "table id";

        public string IdWorkspace { get; set; } = "workspace id";

        public string Label { get; set; } = "tabel label";

        public SelectionType TypeSelection { get; set; }
    }
}