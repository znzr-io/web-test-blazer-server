using System;
using System.Threading;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared._Core
{
	public partial class CP_DropdownItem
    {
        [Parameter]
        public string Label { get; set; } = "-";

        [Parameter]
        public IconName NameIcon { get; set; } = IconName.Alert;

        [Parameter]
        public EventCallback<IconLabelSet> Callback { get; set; }

        [Parameter]
        public bool ShowIconItem { get; set; }



        public class IconLabelSet
        {
            public string? Label { get; set; }

            public IconName? NameIcon { get; set; }
        }



        public async Task OnInvoke()
        {
            IconLabelSet ils = new()
            {
                Label = Label,
                NameIcon = NameIcon
            };

            await Callback.InvokeAsync(ils);
        }
    }
}