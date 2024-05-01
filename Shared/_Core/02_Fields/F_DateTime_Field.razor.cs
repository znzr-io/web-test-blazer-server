using System;
using System.Net.NetworkInformation;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared._Core;



namespace web_test_blazer_server.Shared._Core
{
    public partial class F_DateTime_Field
    {
        void OnDateChanged(DateTime? value)
        {
            Val = value;
        }
    }
}