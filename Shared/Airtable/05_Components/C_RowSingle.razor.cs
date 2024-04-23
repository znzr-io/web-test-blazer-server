using System;
using AirtableApiClient;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;

namespace web_test_blazer_server.Shared.Airtable
{
	public partial class C_RowSingle
    {

        [Parameter]
        public string? Name { get; set; }

        [Parameter]
        public string IdParentMenu { get; set; } = "";

        [Parameter]
        public string IdMenuItem { get; set; } = "";
    }
}