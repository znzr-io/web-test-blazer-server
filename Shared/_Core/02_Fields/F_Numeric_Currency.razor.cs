using System;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared._Core;



namespace web_test_blazer_server.Shared._Core
{
    public partial class F_Numeric_Currency
    {
        public F_Numeric_Currency()
        {
            CurrencySymbol = "€";
        }
    }
}