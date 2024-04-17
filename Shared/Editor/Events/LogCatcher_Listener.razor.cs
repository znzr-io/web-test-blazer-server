using System;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared._Services;



namespace web_test_blazer_server.Shared.Editor
{
	public partial class LogCatcher_Listener
    {
        protected override async Task OnInitializedAsync()
        {
            logCatcher_Service.LogCatched += StateHasChanged;
            await  Task.CompletedTask;
        }



        public void Dispose()
        {
            logCatcher_Service.LogCatched -= StateHasChanged;
        }
    }
}

