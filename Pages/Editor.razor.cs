using web_test_blazer_server.Shared._Core;
using web_test_blazer_server.Shared.Editor;
using Blazorise;



namespace web_test_blazer_server.Pages
{
    public partial class Editor
    {
        double editorUpperSplitViewTop = 68;
        double editorUpperSplitViewCenter = 50;
        double editorUpperSplitViewBottom = 24.2;
        EditorSplitView currentView = EditorSplitView.center;
        ABaseEditorView? viewTop;
        ABaseEditorView? viewBot;

        protected string editorUpperSplit = "";
        protected string editorDownSplit = "";


        public enum EditorSplitView
        {
            topHide,
            topShow,
            center,
            bottomShow,
            bottomHide
        }



        string BaseSplit(double val)
        {
            return $"height: calc({val.ToString()}% - 5px);";
        } 

        

        protected override async Task OnInitializedAsync()
        {
            updateEditorView += (o, args) =>
            {
                SetEditorAirtableSplit(args.EditorView, args.EditorViewToggle);
                //refresh ui
                StateHasChanged();
            };
            await Task.CompletedTask;
        }



        void SetEditorAirtableSplit(EditorSplitView view, ABaseEditorView viewToggle)
        {
            if (view == EditorSplitView.topShow)
                ShowTop(view, viewToggle);

            else if (view == EditorSplitView.center)
                ShowCenter(view, viewToggle);

            else if (view == EditorSplitView.bottomShow)
                ShowBot(view, viewToggle);
        }



        void ShowTop(EditorSplitView view, ABaseEditorView viewToggle)
        {
            viewTop = viewToggle;

            if (currentView == EditorSplitView.bottomHide)
            {
                ShowCenter(view, viewToggle);
            }

            else if (currentView == EditorSplitView.topShow)
            {
                viewTop.NameIcon = IconName.SortUp;
                currentView = EditorSplitView.bottomHide;
                editorUpperSplit = BaseSplit(100);
                editorDownSplit = BaseSplit(0);
            }

            else
            {
                currentView = EditorSplitView.topShow;
                editorUpperSplit = BaseSplit(editorUpperSplitViewTop);
                editorDownSplit = BaseSplit(100 - editorUpperSplitViewTop);
            }
        }



        void ShowCenter(EditorSplitView view, ABaseEditorView viewToggle)
        {
            currentView = EditorSplitView.center;

            editorUpperSplit = BaseSplit(editorUpperSplitViewCenter);
            editorDownSplit = BaseSplit(100 - editorUpperSplitViewCenter);

            System.Console.WriteLine(editorUpperSplit + " ----- " + editorDownSplit);

            if (viewTop != null)
                viewTop.NameIcon = IconName.SortDown;

            if (viewBot != null)
                viewBot.NameIcon = IconName.SortUp;
        }



        void ShowBot(EditorSplitView view, ABaseEditorView viewToggle)
        {
            viewBot = viewToggle;

            if (currentView == EditorSplitView.topHide)
            {
                ShowCenter(view, viewToggle);
            }

            else if (currentView == EditorSplitView.bottomShow)
            {
                viewBot.NameIcon = IconName.SortDown;
                currentView = EditorSplitView.topHide;
                editorUpperSplit = BaseSplit(0);
                editorDownSplit = BaseSplit(100);
            }

            else
            {
                currentView = view;
                editorUpperSplit = BaseSplit(editorUpperSplitViewBottom);
                editorDownSplit = BaseSplit(100 - editorUpperSplitViewBottom);
            }
        }
    }
}