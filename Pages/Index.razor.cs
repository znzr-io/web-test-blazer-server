using System;
using Microsoft.Extensions.Logging;
using web_test_blazer_server.Shared.Airtable;



namespace web_test_blazer_server.Pages
{
	public partial class Index
	{
        private async void Start()
        {
           // await Air.DeSerializeTable();
            //if (Air.Table.agenda == null || Air.Table.agenda.Count < 1)
            //    await Air.GetAirtable();
        }

        protected override async Task OnInitializedAsync()
        {
            await Air.DeSerializeTables();
            
            await Task.CompletedTask;
        }

        public Index()
		{
            //Start();
        }
	}
}

