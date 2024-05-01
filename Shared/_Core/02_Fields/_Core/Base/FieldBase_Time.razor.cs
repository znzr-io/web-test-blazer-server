using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared._Core;



namespace web_test_blazer_server.Shared._Core
{
    public abstract partial class FieldBase_Time
    {
        [Parameter]
        public TimeSpan? Val { get; set; }
    }
}

