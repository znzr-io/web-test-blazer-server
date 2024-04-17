using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class RowDelete
    {
        [Parameter]
        public string Id { get; set; } = "logID";


        bool ReadyToDelete { get; set; }



        public async Task OnInvoke()
        {
            ReadyToDelete = true;
            await LogHandle(Id, "sure to deleted?", Color.Warning);
        }

        public async Task OnCancel()
        {
            ReadyToDelete = false;
            await LogHandle(Id, "delete canceled");
        }

        public async Task OnDelete()
        {
            ReadyToDelete = false;
            await DeleteRow();
            await LogHandle(Id, "row is deleted", Color.Danger);
        }



        public Task DeleteRow()
        {
            return Task.CompletedTask;
        }
    }
}