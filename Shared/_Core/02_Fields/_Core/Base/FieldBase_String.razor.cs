using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared._Core;



namespace web_test_blazer_server.Shared._Core
{
    public abstract partial class FieldBase_String
	{
        [Parameter]
        public string? Val { get; set; }

        [Parameter]
        public int? MaxLength { get; set; }

        [Parameter]
        public TextRole Role { get; set; }



        public virtual void ValidateInput(ValidatorEventArgs e)
        {

        }
    }
}

