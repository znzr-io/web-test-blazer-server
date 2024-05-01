using System;



namespace web_test_blazer_server.Data.Airtable
{
	public class WorkspacesData
    {
		public string? Name { get; set; }
        public string[]? Apps { get; set; }
        public string[]? Tables { get; set; }
        public string? Icon { get; set; }
        public string? Notes { get; set; }
    }
}