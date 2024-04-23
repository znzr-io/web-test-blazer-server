using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared._Core
{
	public partial class BasePionter_Button
    {
        [Parameter]
        public EventCallback<string> SelectedTabChanged { get; set; }



        public async override Task OnInvoke()
        {
            await SelectedTabChanged.InvokeAsync(Label);
            await base.OnInvoke();
        }
    }
}