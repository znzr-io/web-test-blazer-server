using System;

namespace web_test_blazer_server.Shared._Site
{
	public partial class MainNavMenu
	{
        private bool collapseNavMenu = true;

        private string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }

        public MainNavMenu()
		{  
        }
	}
}

