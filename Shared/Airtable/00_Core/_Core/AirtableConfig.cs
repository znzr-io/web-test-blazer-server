namespace web_test_blazer_server.Shared.Airtable;

public static class AirtableConfig
{
    public static string ApiKey { get; private set; }

    public static void Initialize(IConfiguration config)
    {
        ApiKey = config["Airtable:ApiKey"] ?? "";
    }
}