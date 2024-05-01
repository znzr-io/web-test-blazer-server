using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class A_AirtableSync
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
            logCatcher_Service.CatchLog(Id, LogDescriptionSyncing);
            await UpdateAirtable();
        }



        public async Task UpdateAirtable()
        {
            iconActive = iconUpload;
            logCatcher_Service.CatchLog(Id, LogDescriptionUploading);
            await Task.Delay(1000);
            logCatcher_Service.CatchLog(Id, LogDescriptionSuccesUpload, Color.Success);
            await ReloadAirtable();
        }



        public async Task ReloadAirtable()
        {
            string d = "downloading... ";
            iconActive = iconRest; 

            //await Data.Airtable.Airtable.GetAirtable();
            //logCatcher_Service.CatchLog(Id, LogDescriptionSuccesDownload, Color.Success);

            logCatcher_Service.CatchLog(Id, "apps");
            await Data.Airtable.Airtable.ATGetApps();

            logCatcher_Service.CatchLog(Id, d + "workspaces");
            await Data.Airtable.Airtable.ATGetWorkspaces();

            logCatcher_Service.CatchLog(Id, d + "tables");
            await Data.Airtable.Airtable.ATGetTables();

            logCatcher_Service.CatchLog(Id, d + "settings");
            await Data.Airtable.Airtable.ATGetSettings();

            logCatcher_Service.CatchLog(Id, d + "pages");
            await Data.Airtable.Airtable.ATGetPages();

            logCatcher_Service.CatchLog(Id, d + "sections");
            await Data.Airtable.Airtable.ATGetSections();

            logCatcher_Service.CatchLog(Id, d + "text");
            await Data.Airtable.Airtable.ATGetText();

            logCatcher_Service.CatchLog(Id, d + "gallery");
            await Data.Airtable.Airtable.ATGetGallery();

            logCatcher_Service.CatchLog(Id, d + "gallery-item");
            await Data.Airtable.Airtable.ATGetGalleryItem();

            logCatcher_Service.CatchLog(Id, d + "gallery-filter");
            await Data.Airtable.Airtable.ATGetGlleryFilter();

            logCatcher_Service.CatchLog(Id, d + "agenda");
            await Data.Airtable.Airtable.ATGetAgenda();

            logCatcher_Service.CatchLog(Id, d + "contact");
            await Data.Airtable.Airtable.ATGetContact();

            logCatcher_Service.CatchLog(Id, d + "colors");
            await Data.Airtable.Airtable.ATGetColors();
            logCatcher_Service.CatchLog(Id, "done!", Color.Success);

            iconActive = iconRest;
        }
    }
}