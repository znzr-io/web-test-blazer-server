using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared.Editor;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class Sync
    {
        protected IconName iconActive = IconName.Cloud;
        protected IconName iconRest = IconName.Cloud;
        protected IconName iconDownload = IconName.Star;
        protected IconName iconUpload = IconName.CloudUploadAlt;

        protected string LogDescriptionUploading { get; set; } = "uploading...";

        protected string LogDescriptionSyncing { get; set; } = "logDescription";

        protected string LogDescriptionSuccesUpload { get; set; } = "fully UPLOADED";

        protected string LogDescriptionDownloading { get; set; } = "downloading...";

        protected string LogDescriptionSuccesDownload { get; set; } = "fully DOWNLOADED";

        protected string Id { get; set; } = "AIRTABLE";



        public async Task OnSyncAirtable()
        {
            await LogHandle(Id, LogDescriptionSyncing);
            await UpdateAirtable();
        }



        public async Task UpdateAirtable()
        {
            iconActive = iconUpload;
            await LogHandle(Id, LogDescriptionUploading);
            await Task.Delay(1000);
            await LogHandle(Id, LogDescriptionSuccesUpload, Color.Success);
            await ReloadAirtable();
        }



        public async Task ReloadAirtable()
        {
            iconActive = iconRest;
            await Task.Delay(1000);
            await LogHandle(Id, LogDescriptionDownloading);
            await Task.Delay(1000);
            await Data.Airtable.Airtable.GetAirtable();
            await LogHandle(Id, LogDescriptionSuccesDownload, Color.Success);
            iconActive = iconRest;
        }
    }
}