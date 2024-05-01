using System;



namespace web_test_blazer_server.Data.Airtable
{
	public class GalleryFilterData
    {
		public string? Name { get; set; }
        public string? Notes { get; set; }
        public string? Icon { get; set; }
        public string[]? Gallery { get; set; }
    }
}