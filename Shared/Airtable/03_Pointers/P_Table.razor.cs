using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared._Editor;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class P_Table
    {
        [Parameter]
        public EventCallback<string> SetTable { get; set; }



        public override async Task OnInvoke()
        {
            LogDescription = "table is selected";

            if(DataEditor.AccordionSingle == true)
                await SetTable.InvokeAsync(Label);

            await base.OnInvoke();
        }



        public override async Task PointerAction()
        {
            //pointer action
            await Task.CompletedTask;
        }
    }
}