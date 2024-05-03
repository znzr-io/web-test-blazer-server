using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared._Site
{
	public partial class BasePage
    {
        public virtual void ChangeState()
        {
            InvokeAsync(StateHasChanged);
        }
    }
}