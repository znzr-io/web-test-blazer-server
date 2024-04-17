using System;
using Blazorise;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared._Core;
using static web_test_blazer_server.Pages.Editor;



namespace web_test_blazer_server.Shared.Editor
{
	public class ArgsEditorView : EventArgs
	{
		public EditorSplitView EditorView { get; set; }

		public ABaseEditorView EditorViewToggle { get; set; }
    }
}