using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared._Core;



namespace web_test_blazer_server.Shared.Airtable
{
    public partial class ABaseBookmark
	{
        [Parameter]
        public string Id { get; set; } = "logID";
        protected string LogDescription { get; set; } = "bookmarked";
        protected SelectionType TypeBookmark { get; set; } = SelectionType.row;

        protected Color IconColor { get; set; } = Color.Light;
        protected Color IconColorBookMarked { get; set; } = Color.Success;
        protected Color IconColorNotBookMarked { get; set; } = Color.Light;

        bool Bookmarked { get; set; }

        public async virtual Task OnInvoke()
        {
            if (Bookmarked)
            {
                Bookmarked = false;
                IconColor = IconColorNotBookMarked;
                RemoveBookmark();
                logCatcher_Service.CatchLog(Id, "bookmark removed");
            }
            else
            {
                Bookmarked = true;
                IconColor = IconColorBookMarked;
                AddBookmark();
                logCatcher_Service.CatchLog(Id, LogDescription);
            }

            await Task.CompletedTask;
        }



        protected void AddBookmark()
        {

        }



        protected void RemoveBookmark()
        {

        }
    }
}

