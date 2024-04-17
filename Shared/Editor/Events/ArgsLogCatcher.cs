using System;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Editor
{
	public class ArgsLogCatcher : EventArgs
	{
        public string? LogMessage { get; set; } = "logMessage";

        public string? LogDescription { get; set; } = "logDescription";

        public Color LogColor { get; set; } = Color.Dark;
    }
}