using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;



namespace web_test_blazer_server.Shared._Core
{
	public partial class BasePionter
    {
        public bool IsActive { get; private set; }
        public bool IsFocused { get; private set; }
        public bool HasChildren { get; private set; }
        public string IDGUI { get; private set; } = "";
        public BasePionter? ActiveChild { get; private set; }

        [Parameter]
        public BasePionter? Parent { get; set; }

        [Parameter]
        public BasePionter? Self { get; set; }

        [Parameter]
        public string IdMenuItem { get; set; } = "none";

        [Parameter]
        public string IdParentMenu { get; set; } = "none";

        [Parameter]
        public string Label { get; set; } = "label";

        [Parameter]
        public string ToolTip { get; set; } = "label";

        [Parameter]
        public TextColor ColorIcon { get; set; } = TextColor.Default;

        [Parameter]
        public IconName NameIcon { get; set; }

        [Parameter]
        public Background ColorBackground { get; set; } = Background.Default;

        [Parameter]
        public TextColor ColorText { get; set; } = TextColor.Default;

        protected string LogDescription { get; set; } = "label";
        protected Color LogColor { get; set; } = Color.Dark;



        protected override async Task OnInitializedAsync()
        {
            IDGUI = Guid.NewGuid().ToString("N");
            Self = this;
            CheckRoot();
            StateHasChanged();
            await Task.CompletedTask;
        }



        public virtual async Task OnInvoke()
        {
            //CheckRoot();
            //pointer_Service.PointTowards(this);
            logCatcher_Service.CatchLog(Label, LogDescription, LogColor);
            //await PointerAction();
            await Task.CompletedTask;
        }



        public virtual async Task PointerAction()
        {
            await Task.CompletedTask;
        }



        public void SetFocused(bool _state)
        {
            IsFocused = _state;
        }



        public void SetActive(bool _state)
        {
            IsActive = _state;
        }



        public void SetActiveChild(BasePionter _child)
        {
            ActiveChild = _child;
        }



        private void CheckRoot()
        {
            if(pointer_Service != null)
            {
                if (IdParentMenu == "root")
                {
                    pointer_Service.RegisterPointer(this);
                    pointer_Service.PointTowards(this);
                } 
                else 
                    pointer_Service.RegisterPointer(this);

            }
        }
    }
}