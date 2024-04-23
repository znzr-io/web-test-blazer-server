using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;
using web_test_blazer_server.Shared._Editor;


namespace web_test_blazer_server.Shared.Airtable
{
	public partial class PNL_Structure
    {
        public PNL_Structure()
        {
            SelectedTab = "content";
            PanelName = "structure";
        }


        protected override void ServiceReceived()
        {
            SelectedTab = pointer_Service.CurrentPointer.Self.Label;
            base.ServiceReceived();
        }


        protected Task OnSelectedTabChanged(string name)
        {
            SelectedTab = name;

            return Task.CompletedTask;
        }
    }
}