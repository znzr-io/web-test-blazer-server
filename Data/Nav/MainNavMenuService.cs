using System;
using web_test_blazer_server.Design;

namespace web_test_blazer_server.Data.Nav
{
	public class MainNavMenuService
	{
        public MainNavMenuService(){ }

        public List<MainNavMenuData> GetNavItems()
		{
            List<MainNavMenuData> navItems = new();

            MainNavMenuData navItem = new()
            {
                url = "",
                buttonText = "home",
                icon = Icons.home
            };
            navItems.Add(navItem);
                
            MainNavMenuData navItem2 = new()
            {
                url = "counter",
                buttonText = "counter",
                icon = Icons.plus
            };
            navItems.Add(navItem2);

            MainNavMenuData navItem3 = new()
            {
                url = "fetchdata",
                buttonText = "fetchdata",
                icon = Icons.volume_high
            };
            navItems.Add(navItem3);

            MainNavMenuData navItem4 = new()
            {
                url = "test/testPage",
                buttonText = "tester",
                icon = Icons.command
            };
            navItems.Add(navItem4);

            return navItems;
        }



        public Task<List<MainNavMenuData>> GetMenuAsync()
        {
            return Task.FromResult(GetNavItems());
        }
    }
}