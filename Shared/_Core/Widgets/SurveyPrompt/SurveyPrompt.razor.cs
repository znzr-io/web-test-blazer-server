using System;
using Microsoft.AspNetCore.Components;

namespace web_test_blazer_server.Shared._Core
{
	public partial class SurveyPrompt
	{

		private string? title = "bla";

        [Parameter]
        public string? Title { get { return title; } set { title = value; } }

        public SurveyPrompt()
		{
		}
	}
}

