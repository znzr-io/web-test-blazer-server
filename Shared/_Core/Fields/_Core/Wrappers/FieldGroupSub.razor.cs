using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared._Core
{
    public partial class FieldGroupSub
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}

