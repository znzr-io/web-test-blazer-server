using System;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Editor
{
	public partial class Footer
    {
		private string? logMessage = "logMessage";

        [Parameter]
        public string? LogMessage { get { return logMessage; } set { logMessage = value; } }

        int counter;

        public Task OnLoadAirtable()
        {
            counter++;

            return Task.CompletedTask;
        }

        public Task OnCloseEditor()
        {
            counter++;

            return Task.CompletedTask;
        }
    }
}