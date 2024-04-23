using System;
using System.ComponentModel.DataAnnotations;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared._Core;



namespace web_test_blazer_server.Shared._Core
{
    public partial class BaseF_Text
	{
        [Parameter]
        public Action<ValidatorEventArgs>? Validator { get; set; }



        public BaseF_Text()
        {
            BadgeColor = Color.Info;
        }
    }
}