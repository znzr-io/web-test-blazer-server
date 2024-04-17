using System;
using web_test_blazer_server.Data;
using web_test_blazer_server.Data.Nav;
using static web_test_blazer_server.Data.Nav.MainNavMenuData;

namespace web_test_blazer_server.Shared._Site
{
	public partial class MainNavMenuItem
	{
        private List<MainNavMenuData>? Menu { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Menu = await MainNavMenuService.GetMenuAsync();
        }
	}
}