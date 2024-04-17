using System;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Editor
{
	public partial class Footer
    {


        public Task OnClickLog()
        {
            System.Console.WriteLine("console clicked");
            return Task.CompletedTask;
        }
    }
}