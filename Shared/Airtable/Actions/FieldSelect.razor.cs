using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared.Airtable
{
	public partial class FieldSelect
    {
        [Parameter]
        public string Id { get; set; } = "logID";

        [Parameter]
        public string Label { get; set; } = "field name";

        [Parameter]
        public Color ColorSelector { get; set; } = Color.Light;

        [Parameter]
        public IconName NameIcon { get; set; } = IconName.ArrowRight;



        public async Task OnInvoke()
        {
            await LogHandle(Label.ToUpper(), "field is selected");
        }
    }
}