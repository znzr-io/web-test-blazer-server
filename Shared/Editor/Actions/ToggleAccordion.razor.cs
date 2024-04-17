using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;


namespace web_test_blazer_server.Shared.Editor
{
	public partial class ToggleAccordion
    {
        IconName icon = IconName.Star;

        public static bool AccordionSingle = true;

        string msg = "single";


        public async Task OnInvoke()
        {
            AccordionSingle = !AccordionSingle;

            if (AccordionSingle == true)
                msg = "single";
            else
                msg = "multi";

            await LogHandle("TABLE", $"open {msg}");
        }
    }
}