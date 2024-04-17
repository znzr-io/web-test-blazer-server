using System;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Editor
{
	public partial class Console
    {
		private string? logMessage = "logMessage";
        private string? logDescription = "logDescription";
        private Color logColor = Color.Success;



        [Parameter]
        public string? LogMessage { get { return logMessage; } set { logMessage = value; } }

        [Parameter]
        public string? LogDescription { get { return logDescription; } set { logDescription = value; } }

        [Parameter]
        public Color LogColor { get { return logColor; } set { logColor = value; } }
	}
}

