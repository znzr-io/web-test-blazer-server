using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;


namespace web_test_blazer_server.Shared.Editor
{ 
    public partial class ViewTop
    {
        public async Task OnInvoke()
        {
            await EditorViewHandle(Pages.Editor.EditorSplitView.topShow);
            await LogHandle("EDITOR", "focus top");
        }
    }
}