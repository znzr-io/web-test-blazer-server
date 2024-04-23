using System;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared._Core;



namespace web_test_blazer_server.Shared._Core
{
    public partial class F_Code
    {
        [Parameter]
        public int Rows { get; set; }

        [Parameter]
        public bool ReplaceTab { get; set; }

        [Parameter]
        public int TabSize { get; set; }

        [Parameter]
        public bool AutoSize { get; set; }



        public F_Code()
        {
            BadgeColor = Color.Info;
        }
    }
}