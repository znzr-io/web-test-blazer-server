using System;
using AirtableApiClient;



namespace web_test_blazer_server.Shared.Airtable
{
	public class DishIngredientsData
    {
		public string? Name { get; set; }
        public string? Description { get; set; }
        public string[]? Color { get; set; }
    }
}