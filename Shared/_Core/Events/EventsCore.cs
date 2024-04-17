using System;
using Microsoft.AspNetCore.Components;
using web_test_blazer_server.Shared.Airtable;
using web_test_blazer_server.Shared.Editor;



namespace web_test_blazer_server.Shared._Core
{
	public class EventsEditor : ComponentBase
	{
        public static event EventHandler<ArgsEditorView>? updateEditorView;
        public static event EventHandler<ArgsLogCatcher>? catchLog;
        public static event EventHandler<ArgsPointerSelection>? pointerSelection;


        public void ChangeEditorView(ArgsEditorView args)
        {
            updateEditorView?.Invoke(this, new ArgsEditorView { EditorView = args.EditorView, EditorViewToggle = args.EditorViewToggle });
        }


        public void PointerSelection(ArgsPointerSelection args)
        {
            pointerSelection?.Invoke(this, new ArgsPointerSelection { IdWorkspace = args.IdWorkspace, IdTable = args.IdTable, IdRow = args.IdRow, IdRecord = args.IdRecord, Label = args.Label, TypeSelection = args.TypeSelection});
        }



        public void CatchingLog(ArgsLogCatcher args)
		{
			catchLog?.Invoke(this, new ArgsLogCatcher { LogMessage = args.LogMessage, LogDescription = args.LogDescription, LogColor = args.LogColor });
        }
	}
}