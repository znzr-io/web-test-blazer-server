using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared._Core;
using web_test_blazer_server.Shared.Editor;

namespace web_test_blazer_server.Shared._Core
{
    public partial class ABase
	{
        public async Task LogHandle(string _logMessage, string _logDescription, Color _logColor)
        {
            ArgsLogCatcher a = new()
            {
                LogMessage = _logMessage.ToUpper(),
                LogDescription = _logDescription,
                LogColor = _logColor
            };

            CatchingLog(a);

            await Task.CompletedTask;
        }


        public async Task LogHandle(string _logMessage, string _logDescription)
        {
            ArgsLogCatcher a = new()
            {
                LogMessage = _logMessage.ToUpper(),
                LogDescription = _logDescription
            };

            CatchingLog(a);

            await Task.CompletedTask;
        }
    }
}

