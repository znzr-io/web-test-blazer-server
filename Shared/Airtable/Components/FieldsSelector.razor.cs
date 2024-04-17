using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class FieldsSelector
    {
        Dropdown dropdown;

        Task ShowMenu()
        {
            return dropdown.Show();
        }
    }
}