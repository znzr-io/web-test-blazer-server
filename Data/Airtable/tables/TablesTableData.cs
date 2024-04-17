using System;
namespace web_test_blazer_server.Data.Airtable
{
	public class TablesTableData
	{
		public string? Name { get; set; }
        public string? Workspace { get; set; }
        public int Max_Rows { get; set; }
        public bool Allow_Add { get; set; }
        public bool Allow_Delete { get; set; }
        public bool Bookmarked { get; set; }
        public bool Bookmark_AddNewRow { get; set; }
        public bool Bookmark_AllowRemoveFrom { get; set; }
        public string? TableID { get; set; }
        public string? TableURL { get; set; }

    }
}