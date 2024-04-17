using System;
using web_test_blazer_server.Data.Airtable;



namespace web_test_blazer_server.Pages
{
	public partial class Index
	{
        private async void Start()
        {
            if (Airtable.Tables.agenda == null || Airtable.Tables.agenda.Count < 1)
                await Airtable.GetAirtable();
        }

        public Index()
		{
            //Start();
        }
	}
}

