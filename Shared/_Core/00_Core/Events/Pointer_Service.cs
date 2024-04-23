using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Blazorise;
using static web_test_blazer_server.Pages.Editor;
using web_test_blazer_server.Shared._Core;
using System.Collections;
using Blazorise.Bootstrap5.Components;

//!!!!!! IMPLEMENT IN PROGRAM.CS -> builder.Services.AddScoped<Pointer_Service>();

namespace web_test_blazer_server.Shared._Editor
{
	public class Pointer_Service
    {
        LogCatcher_Service log = new();

        public event Action? ServiceAction;

        public Pointer CurrentPointer { get; set; } = new();

        public string CurrentMenuItem { get; set; } = "";

        public string CurrentParentMenu { get; set; } = "";

        public List<Pointer> CurrentPath { get; set; } = new();

        public int PathDepth { get { return GetPathDepth(); } }

        public Dictionary<string, Dictionary<string, Pointer>> AllPointers { get; set; } = new();

        public int AmountMenus { get { return GetAmountMenus(); } }

        public int AmountPointers { get { return GetAmountPointers(); } }

        public class Pointer
        {
            public string IdParentMenu { get; set; } = "";

            public BasePionter? Self { get; set; }
        }



        public void PointTowards(BasePionter _self)
        {
            //System.Console.WriteLine("Pointer_Service.PointTowards() : " + _self.IdMenuItem);

            ////CreatePointer(_self);
            ////SetAllPointers();
            //DeactivateAllPointers();
            //CreatePath();

            //ServiceAction?.Invoke();
        }

        

        public void RegisterPointer(BasePionter _self)
        {
            //CreatePointer(_self);
            //SetAllPointers();
        }



        private int GetPathDepth()
        {
            int v = CurrentPath.Count;

            return v;
        }



        private int GetAmountMenus()
        {
            int v = AllPointers.Count;

            return v;
        }



        private int GetAmountPointers()
        {
            int v = 0;

            foreach (KeyValuePair<string, Dictionary<string, Pointer>> entry in AllPointers)
            {
                foreach (KeyValuePair<string, Pointer> p in entry.Value)
                {
                    if (p.Value != null)
                    {
                        v++;
                    }
                }
            }

            return v;
        }



        private void CreatePointer(BasePionter _self)
        {
            CurrentMenuItem = _self.IdMenuItem;
            CurrentParentMenu = _self.IdParentMenu;

            CurrentPointer = new();
            CurrentPointer.IdParentMenu = CurrentParentMenu;
            CurrentPointer.Self = _self;
        }



        private void CreatePath()
        {
            CurrentPath = new();

            if(CurrentPointer.Self != null)
            {
                CurrentPointer.Self.SetActive(true);
                CurrentPointer.Self.SetFocused(true);
            }

            GetParents(CurrentPointer);
            CurrentPath.Add(CurrentPointer);
        }



        private void GetParents(Pointer p)
        {
            Pointer parent;

            //System.Console.WriteLine($"Pointer_Service.GetParents s[  {p.Self.IdParentMenu}  ]");

            if (p.Self != null)
            {
                if (p.Self.IdParentMenu != "" && p.Self.IdParentMenu != null && p.Self.IdParentMenu != "root")
                {
                    parent = SearchParent(p.Self.IdParentMenu, p);

                    if (parent != null)
                    {
                        GetParents(parent);
                        CurrentPath.Add(parent);
                    }
                }
            }
        }



        private Pointer SearchParent(string _idParentMenu, Pointer _child)
        {
            Pointer parent = new();

            foreach (KeyValuePair<string, Dictionary<string, Pointer>> parentMenuId in AllPointers)
            {
                if(parentMenuId.Key != _idParentMenu)
                {
                    foreach (KeyValuePair<string, Pointer> p in parentMenuId.Value)
                    {
                        //check for sibling pointers? > changing tables = changing dropdowns
                        //set them active but remove from the breadcrumbs

                        //System.Console.WriteLine($"Pointer_Service.GetParents s[  {p.Value.Self.IdMenuItem}  ] : p[  {_idParentMenu}  ] : pp[  {p.Value.Self.IdParentMenu}  ]");

                        if (p.Value != null && p.Value.Self.IdMenuItem == _idParentMenu)
                        {
                            System.Console.WriteLine($"Pointer_Service.SearchParents s[  {p.Value.Self.IdMenuItem}  ] : p[  {_idParentMenu}  ] : pp[  {p.Value.Self.IdParentMenu}  ]");
                            parent = p.Value;
                            if(parent.Self != null)
                            {
                                parent.Self.SetActiveChild(_child.Self);
                                parent.Self.SetActive(true);
                            }   
                        }
                    }
                }
            }
            return parent;
        }



        private void SetAllPointers()
        {
            if(CurrentPointer.Self != null)
            {
                if (AllPointers.ContainsKey(CurrentPointer.IdParentMenu))
                {
                    AllPointers[CurrentPointer.IdParentMenu].TryAdd(CurrentPointer.Self.IDGUI, CurrentPointer);
                }

                else
                {
                    Dictionary<string, Pointer> pointers = new();
                    pointers.Add(CurrentPointer.Self.IDGUI, CurrentPointer);
                    AllPointers.TryAdd(CurrentPointer.IdParentMenu, pointers);
                }
            }
        }



        private void DeactivateAllPointers()
        {
            foreach (KeyValuePair<string, Dictionary<string, Pointer>> entry in AllPointers)
            {
                foreach (KeyValuePair<string, Pointer> p in entry.Value)
                {
                    if (p.Value != null)
                    {
                        if (p.Value.Self != null)
                        {
                            p.Value.Self.SetActive(false);
                            p.Value.Self.SetFocused(false);
                        }
                    }
                }
            }
        }
    }
}