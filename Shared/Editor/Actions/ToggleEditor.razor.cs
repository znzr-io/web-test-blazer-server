using System;
using System.Net.NetworkInformation;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Data.Airtable;


namespace web_test_blazer_server.Shared.Editor
{
	public partial class ToggleEditor
    {
        IconName NameIconOpenEditor = IconName.ArrowLeft;
        IconName NameIconCloseEditor = IconName.ArrowRight;

        public ToggleEditorState State { get; set; } = ToggleEditorState.openEditor;

        ToggleEditorState buttonType;

        [Parameter]
        public ToggleEditorState ButtonType
        {
            get
            {
                return buttonType;
            }
            set
            {
                buttonType = value;
                SetIcon(buttonType);
            }

        }



        public enum ToggleEditorState
        {
            openEditor,
            closeEditor
        }



        public void SetIcon(ToggleEditorState _buttonType)
        {
            if (_buttonType == ToggleEditorState.openEditor)
                NameIcon = NameIconOpenEditor;
            else
                NameIcon = NameIconCloseEditor;
        }




        async Task EditorOpen()
        {
            await EditorViewHandle(true);
            await LogHandle("EDITOR", "welcome");
        }



        async Task EditorClose()
        {
            await EditorViewHandle(false);
            await LogHandle("EDITOR", "closed");
        }



        public async Task OnInvoke()
        {
            if(ButtonType == ToggleEditorState.openEditor)
                await EditorOpen();
            else
                await EditorClose();
        }
    }
}