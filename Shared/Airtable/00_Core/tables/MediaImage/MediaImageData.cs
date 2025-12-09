using System;
using AirtableApiClient;



namespace web_test_blazer_server.Shared.Airtable
{
	public class MediaImageData : BaseMediaType
    {
        public string? Alt { get; set; }
        public string? Loading { get; set; }
    }
}