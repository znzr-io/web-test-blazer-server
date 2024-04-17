using System;
using AirtableApiClient;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;
using web_test_blazer_server.Shared.Airtable;


namespace web_test_blazer_server.Shared._Services
{
	public partial class PointerSelection_Handle
    {
        PointerSelection_Args? argsSelect;

        public string IdRecord { get; set; } = "row id";

        public string IdRow { get; set; } = "row id";

        public string IdTable { get; set; } = "table id";

        public string IdWorkspace { get; set; } = "workspace id";

        [Parameter]
        public string Label { get; set; } = "selection label";



        protected override async Task OnInitializedAsync()
        {
            /*
           pointerSelection += (o, args) =>
           {
               IdRecord = args.IdRecord;
               IdRow = args.IdRow;
               IdTable = args.IdTable;
               IdWorkspace = args.IdWorkspace;
               Label = args.Label;

               _ = OnInvoke();

               //refresh ui
               StateHasChanged();
           };
            */

           await Task.CompletedTask;
        }


        public virtual async Task OnInvoke()
        {
            await Task.CompletedTask;
        }
    }
}