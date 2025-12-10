using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared._Site;
using web_test_blazer_server.Shared.Airtable;



namespace web_test_blazer_server.Shared._Site
{
	public partial class C_DishSection
    {
        [Parameter]
        public TableDishIngredients Records { get; set; } = new();

        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        public C_DishSection()
        {
            Class = "section-dish";
        }
    }
}

