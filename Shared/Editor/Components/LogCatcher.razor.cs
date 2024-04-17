using System;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Editor
{
	public partial class LogCatcher
    {
        ArgsLogCatcher? argsLogCatcher;

        //[Parameter]
        public string? LogMessage { get; set; } = "Welcome";

        //[Parameter]
        public string? LogDescription { get; set; } = "...";

        //[Parameter]
        public Color LogColor { get; set; } = Color.Dark;



        protected override async Task OnInitializedAsync()
        {
            catchLog += (o, args) =>
            {
                LogMessage = args.LogMessage;
                LogDescription = args.LogDescription;

                if (args.LogColor != null)
                    LogColor = args.LogColor;

                //refresh ui
                StateHasChanged();
            };
            await  Task.CompletedTask;
        }
    }
}

