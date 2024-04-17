using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class BookmarkDelete
    {
        [Parameter]
        public bool AllowRemoveBookmark { get; set; }

        [Parameter]
        public string Id { get; set; } = "logID";

        bool ReadyToDelete { get; set; }



        public async Task OnInvoke()
        {
            ReadyToDelete = true;
            await DeleteBookmark();
            await LogHandle(Id, "bookmark deleted", Color.Danger);
        }



        public Task DeleteBookmark()
        {
            return Task.CompletedTask;
        }
    }
}