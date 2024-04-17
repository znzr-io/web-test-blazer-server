using System;
using AirtableApiClient;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared._Core;
using web_test_blazer_server.Shared.Editor;



namespace web_test_blazer_server.Shared._Core
{
    public partial class ABaseEditorView
    {
        [Parameter]
        public IconName NameIcon { get; set; }






        public async Task EditorViewHandle(Pages.Editor.EditorSplitView _view)
        {
            ArgsEditorView a = new()
            {
                EditorView = _view,
                EditorViewToggle = this
            };

            ChangeEditorView(a);

            await Task.CompletedTask;
        }
    }
}

