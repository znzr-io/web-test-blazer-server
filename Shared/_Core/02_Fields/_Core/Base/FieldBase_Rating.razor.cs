using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared._Core;



namespace web_test_blazer_server.Shared._Core
{
    public abstract partial class FieldBase_Rating
    {
        public int Val { get; set; }

        [Parameter]
        public int InitVal { get; set; }



        protected override Task OnInitializedAsync()
        {
            Val = InitVal;
            return base.OnInitializedAsync();
        }
    }   
}

