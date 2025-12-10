using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared.Airtable;



namespace web_test_blazer_server.Shared._Site
{
	public partial class C_AboutSection
    {

        public C_AboutSection()
        {
            System.Console.WriteLine("C_AboutSection : " + Section);

            Class = "section-about";
        }
    }
}

