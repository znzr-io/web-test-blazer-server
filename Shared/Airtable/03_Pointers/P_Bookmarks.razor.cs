using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class P_Bookmarks
    {
        Dropdown dropdown = new();

        Task ShowMenu()
        {
            return dropdown.Show();
        }
    }
}