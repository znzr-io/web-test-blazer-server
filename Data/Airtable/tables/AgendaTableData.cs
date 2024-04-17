using System;
namespace web_test_blazer_server.Data.Airtable
{
	public class AgendaTableData
	{
		public string? Name { get; set; }
        public bool Publish { get; set; }
        public string? Location { get; set; }
        public string? Date_From { get; set; }
        public string? Date_Till { get; set; }
        public string? Organizer { get; set; }
        public string? Type { get; set; }
        public string? Notes { get; set; }

    }
}