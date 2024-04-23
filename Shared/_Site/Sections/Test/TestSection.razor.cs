using System;
using Microsoft.AspNetCore.Components;

namespace web_test_blazer_server.Shared._Core
{
	public partial class TestSection
	{
		[Parameter]
		public string? Name { get; set; }

        [Parameter]
        public string? Down { get; set; }

        public TestSection()
		{
		}
	}
}

