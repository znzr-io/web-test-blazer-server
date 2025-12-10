using System;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared.Airtable;

namespace web_test_blazer_server.Shared._Site
{
	public partial class SectionBase
    {
        [Parameter]
		public string? Id { get; set; } = "agenda";

		[Parameter]
		public string? Class { get; set; } = "section-agenda";

        [Parameter]
        public SectionData Section { get; set; } = new();

	}
}

