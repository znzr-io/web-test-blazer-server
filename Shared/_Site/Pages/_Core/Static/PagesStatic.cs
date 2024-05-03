using System;
namespace web_test_blazer_server.Shared._Site
{
	public static class PagesStatic
	{
		public static Dictionary<string, BasePage> pages = new();


		public static void ChangeState()
		{
			foreach (KeyValuePair<string, BasePage> p in pages)
				p.Value.ChangeState();
        }
	}
}