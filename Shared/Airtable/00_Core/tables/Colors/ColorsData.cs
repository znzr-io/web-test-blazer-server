using System;
using AirtableApiClient;



namespace web_test_blazer_server.Shared.Airtable
{
	public class ColorsData
    {
		public string? Name { get; set; }
        public string? Hex { get; set; }
        public int? R { get; set; }
        public int? G { get; set; }
        public int? B { get; set; }
        public float? A { get; set; }
    }
}