using System;
using Blazorise;
using Microsoft.AspNetCore.Components;
using static web_test_blazer_server.Pages.Editor;
using web_test_blazer_server.Shared._Core;

//!!!!!! IMPLEMENT IN PROGRAM.CS -> builder.Services.AddScoped<EditorView_Service>();

namespace web_test_blazer_server.Shared.Editor
{
	public class EditorVisibility_Service
    {
        public bool ShowEditor { get; set; } = true;

        public event Action? EditorVisibilityToggled;



		public void ToggleEditorVisibility(bool _showEditor)
        {
            ShowEditor = _showEditor;

            EditorVisibilityToggled?.Invoke();
        }
    }
}