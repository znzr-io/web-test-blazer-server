using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared._Core;
using web_test_blazer_server.Shared._Services;
using web_test_blazer_server.Shared.Editor;



namespace web_test_blazer_server.Shared._Core
{
    public partial class APostBase_LogCatcher
	{
        public async Task LogHandle(string _logMessage, string _logDescription, Color _logColor)
        {
            logCatcher_Service.CatchLog(_logMessage, _logDescription, _logColor);

            await Task.CompletedTask;
        }



        public async Task LogHandle(string _logMessage, string _logDescription)
        {
            logCatcher_Service.CatchLog(_logMessage, _logDescription);

            //CatchingLog(a);

            await Task.CompletedTask;
        }
    }
}

