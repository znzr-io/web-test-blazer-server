using System;
using AirtableApiClient;



namespace web_test_blazer_server.Data.Airtable
{
	public static class Airtable
	{
        public static readonly string BASE_ID = "appw7gx55EkqWeWrs";
        public static readonly string API_KEY = "patPlJVFWYpPWYR0z.994e57da7debd9f777f139c65ca7d44c86af9373e6855cede2092718c90b15af";



        public static class Tables
        {
            public static List<AirtableRecord<TablesTableData>> tables = new();
            public static List<AirtableRecord<AgendaTableData>> agenda = new();
        }



        public static async Task GetAirtable()
        {
            
            //status reading table table
            TablesTableService tablesTable = new();
            Tables.tables = await tablesTable.GetRecords();
            /*
            Console.WriteLine(Tables.tables[0].Fields.Name);
            Console.WriteLine(Tables.tables[1].Fields.Name);
            Console.WriteLine(Tables.tables[2].Fields.Name);
            */
            

            //status reading table table
            AgendaTableService agendaTable = new();
            Tables.agenda = await agendaTable.GetRecords();
            
            Console.WriteLine(Tables.agenda[0].Fields.Name);
            Console.WriteLine(Tables.agenda[1].Fields.Name);
            Console.WriteLine(Tables.agenda[2].Fields.Name);
           
            //status reading tables done
        }



        public static async Task SetAirtable()
        {
            //SET ALL TABLES + RECORDS TO AIRTABLE
            //status writing tables

            await GetAirtable();
        }
    }
}