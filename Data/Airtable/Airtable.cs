using System;
using AirtableApiClient;
using web_test_blazer_server.Shared._Editor;



namespace web_test_blazer_server.Data.Airtable
{
	public static class Airtable
	{
        public static readonly string BASE_ID = "appw7gx55EkqWeWrs";
        public static readonly string API_KEY = "patPlJVFWYpPWYR0z.994e57da7debd9f777f139c65ca7d44c86af9373e6855cede2092718c90b15af";



        public static class Tables
        {
            public static List<AirtableRecord<AppsData>> apps = new();
            public static List<AirtableRecord<WorkspacesData>> workspaces = new();
            public static List<AirtableRecord<TablesData>> tables = new();

            public static List<AirtableRecord<SettingsData>> settings = new();
            public static List<AirtableRecord<PagesData>> pages = new();
            public static List<AirtableRecord<SectionData>> sections = new();
            public static List<AirtableRecord<TextData>> text = new();
            public static List<AirtableRecord<GalleryData>> gallery = new();
            public static List<AirtableRecord<GalleryItemData>> galleryItem = new();
            public static List<AirtableRecord<GalleryFilterData>> galleryFilter = new();
            public static List<AirtableRecord<AgendaData>> agenda = new();
            public static List<AirtableRecord<ContactData>> contact = new();
            public static List<AirtableRecord<ColorsData>> colors = new();
        }



        public static async Task ATGetApps()
        {
            AppsService appsTable = new();
            Tables.apps = await appsTable.GetRecords();
        }



        public static async Task ATGetWorkspaces()
        {
            WorkspacesService workspacesTable = new();
            Tables.workspaces = await workspacesTable.GetRecords();
        }



        public static async Task ATGetTables()
        {
            TablesService tablesTable = new();
            Tables.tables = await tablesTable.GetRecords();
        }



        public static async Task ATGetSettings()
        {
            SettingsService settingsTable = new();
            Tables.settings = await settingsTable.GetRecords();
        }



        public static async Task ATGetPages()
        {
            PagesService pagesTable = new();
            Tables.pages = await pagesTable.GetRecords();
        }



        public static async Task ATGetSections()
        {
            SectionService sectionsTable = new();
            Tables.sections = await sectionsTable.GetRecords();
        }



        public static async Task ATGetText()
        {
            TextService textTable = new();
            Tables.text = await textTable.GetRecords();
        }



        public static async Task ATGetGallery()
        {
            GalleryService galleryTable = new();
            Tables.gallery = await galleryTable.GetRecords();
        }



        public static async Task ATGetGalleryItem()
        {
            GalleryItemService galleryItemTable = new();
            Tables.galleryItem = await galleryItemTable.GetRecords();
        }



        public static async Task ATGetGlleryFilter()
        {
            GalleryFilterService galleryFilterTable = new();
            Tables.galleryFilter = await galleryFilterTable.GetRecords();
        }



        public static async Task ATGetAgenda()
        {
            AgendaService agendaTable = new();
            Tables.agenda = await agendaTable.GetRecords();
        }



        public static async Task ATGetContact()
        {
            ContactService contactTable = new();
            Tables.contact = await contactTable.GetRecords();
        }



        public static async Task ATGetColors()
        {
            ColorsService colorsTable = new();
            Tables.colors = await colorsTable.GetRecords();
        }



        public static async Task GetAirtable()
        {
            LogCatcher_Service logCatcher_Service = new();
            string Id = "AIRTABLE";
            string d = "downloading... ";

            await ATGetApps();

            /*
            Console.WriteLine("APPS.Name " + Tables.apps[0].Fields.Name);

            for(int i = 0; i < Tables.apps[0].Fields.Workspaces.Length; i++)
            {
                Console.WriteLine("APPS.Workspaces " + Tables.apps[0].Fields.Workspaces[i]);
            }
           
            Console.WriteLine("APPS.Icon " + Tables.apps[0].Fields.Icon);
            Console.WriteLine("APPS.Notes " + Tables.apps[0].Fields.Notes);
            */


            await ATGetWorkspaces();


            /*
            Console.WriteLine("WORKSPACES.Name " + Tables.workspaces[0].Fields.Name);
            Console.WriteLine("WORKSPACES.Apps length " + Tables.workspaces[0].Fields.Apps.Length);
            
            for (int i = 0; i < Tables.workspaces[0].Fields.Apps.Length; i++)
            {
                Console.WriteLine("WORKSPACES.Apps " + Tables.workspaces[0].Fields.Apps[i]);
            }

            Console.WriteLine("WORKSPACES.Tables length " + Tables.workspaces[0].Fields.Tables.Length);

            for (int i = 0; i < Tables.workspaces[0].Fields.Tables.Length; i++)
            {
                Console.WriteLine("WORKSPACES.Tables " + Tables.workspaces[0].Fields.Tables[i]);
            }

            Console.WriteLine("WORKSPACES.Icon " + Tables.workspaces[0].Fields.Icon);
            Console.WriteLine("WORKSPACES.Notes " + Tables.workspaces[0].Fields.Notes);
            */



            await ATGetTables();

            /*
            Console.WriteLine("TABLES.Name " + Tables.tables[3].Fields.Name);

            Console.WriteLine("TABLES.Workspace length " + Tables.tables[3].Fields.Workspace.Length);

            for (int i = 0; i < Tables.tables[0].Fields.Workspace.Length; i++)
            {
                Console.WriteLine("TABLES.Workspace " + Tables.tables[3].Fields.Workspace[i]);
            }

            Console.WriteLine("TABLES.Icon " + Tables.tables[3].Fields.Icon);
            Console.WriteLine("TABLES.MaxRows " + Tables.tables[3].Fields.Max_Rows);
            Console.WriteLine("TABLES.AllowAd " + Tables.tables[3].Fields.Allow_Add);
            Console.WriteLine("TABLES.AllowDelete " + Tables.tables[3].Fields.Allow_Delete);
            Console.WriteLine("TABLES.Bookmarked " + Tables.tables[3].Fields.Bookmarked);
            Console.WriteLine("TABLES.BookmarkAddNewRow " + Tables.tables[3].Fields.Bookmark_AddNewRow);
            Console.WriteLine("TABLES.BookmarkAllowRemoveFrom " + Tables.tables[3].Fields.Bookmark_AllowRemoveFrom);
            Console.WriteLine("TABLES.TableID " + Tables.tables[3].Fields.TableID);
            Console.WriteLine("TABLES.TableUrl " + Tables.tables[3].Fields.TableURL);
            */


            await ATGetSettings();



            /*
            Console.WriteLine("SETTINGS.Name " + Tables.settings[0].Fields.Name);
            Console.WriteLine("SETTINGS.Notes " + Tables.settings[0].Fields.Notes);
            */


            await ATGetPages();


            /*
            Console.WriteLine("PAGES.Name " + Tables.pages[1].Fields.Name);
            Console.WriteLine("PAGES.Template " + Tables.pages[1].Fields.Template);
            Console.WriteLine("PAGES.Publish " + Tables.pages[1].Fields.Publish);
            Console.WriteLine("PAGES.IsEditor " + Tables.pages[1].Fields.IsEditor);
            Console.WriteLine("PAGES.Notes " + Tables.pages[1].Fields.Notes);
            Console.WriteLine("PAGES.Pagename " + Tables.pages[1].Fields.Pagename);
            Console.WriteLine("PAGES.Slug " + Tables.pages[1].Fields.Slug);
            Console.WriteLine("PAGES.SeoTitle " + Tables.pages[1].Fields.SeoTitle);
            Console.WriteLine("PAGES.SeoMeta " + Tables.pages[1].Fields.SeoMeta);
            Console.WriteLine("PAGES.OpengraphTitle " + Tables.pages[1].Fields.OpengraphTitle);
            Console.WriteLine("PAGES.OpengraphTitleIsSeoTitle " + Tables.pages[1].Fields.OpengraphTitleIsSeoTitle);
            Console.WriteLine("PAGES.OpengraphDescription " + Tables.pages[1].Fields.OpengraphDescription);
            Console.WriteLine("PAGES.OpengraphDescriptionIsSeoDescription " + Tables.pages[1].Fields.OpengraphDescriptionIsSeoDescription);
            Console.WriteLine("PAGES.SearchExclude " + Tables.pages[1].Fields.SearchExclude);
            Console.WriteLine("PAGES.SearchTitle " + Tables.pages[1].Fields.SearchTitle);
            Console.WriteLine("PAGES.SearchDescription " + Tables.pages[1].Fields.SearchDescription);
            Console.WriteLine("PAGES.SearchDescriptionIsSeoDescription " + Tables.pages[1].Fields.SearchDescriptionIsSeoDescription);
            Console.WriteLine("PAGES.SearchImageIsOpengrapImage " + Tables.pages[1].Fields.SearchImageIsOpengrapImage);

            Console.WriteLine("PAGES.SearchImage " + Tables.pages[1].Fields.SearchImage[0].Filename);
            Console.WriteLine("PAGES.SearchImage " + Tables.pages[1].Fields.SearchImage[0].Id);
            Console.WriteLine("PAGES.SearchImage " + Tables.pages[1].Fields.SearchImage[0].Size);
            Console.WriteLine("PAGES.SearchImage " + Tables.pages[1].Fields.SearchImage[0].Thumbnails);
            Console.WriteLine("PAGES.SearchImage " + Tables.pages[1].Fields.SearchImage[0].Type);
            Console.WriteLine("PAGES.SearchImage " + Tables.pages[1].Fields.SearchImage[0].Url);

            Console.WriteLine("PAGES.OpengraphImageUrl1200x630 " + Tables.pages[1].Fields.OpengraphImageUrl1200x630.Count);

            Console.WriteLine("PAGES.Sections length " + Tables.pages.Count);

            if(Tables.pages[0].Fields.Sections != null)
                Console.WriteLine("PAGES.Sections 0 length " + Tables.pages[0].Fields.Sections.Length);

            if (Tables.pages[1].Fields.Sections != null)
                Console.WriteLine("PAGES.Sections 1 length " + Tables.pages[1].Fields.Sections.Length);
            */


            //Console.WriteLine("PAGES.Name " + Tables.pages.Where(n => n.Fields.Name == "page").Select());



            await ATGetSections();

            /*
            Console.WriteLine("SECTIONS.Name " + Tables.sections[0].Fields.Name);

            if (Tables.sections[0].Fields.Pages != null)
                Console.WriteLine("SECTIONS.Pages 0 length " + Tables.sections[0].Fields.Pages.Length);

            if (Tables.sections[0].Fields.TextButton != null)
                Console.WriteLine("SECTIONS.TextButton 0 length " + Tables.sections[0].Fields.TextButton.Length);

            if (Tables.sections[0].Fields.TextHeader != null)
                Console.WriteLine("SECTIONS.TextHeader 0 length " + Tables.sections[0].Fields.TextHeader.Length);

            if (Tables.sections[0].Fields.TextBody != null)
                Console.WriteLine("SECTIONS.TextBody 0 length " + Tables.sections[0].Fields.TextBody.Length);

            Console.WriteLine("SECTIONS.TextBody 0 length " + Tables.sections[0].Fields.Icon);

            if (Tables.sections[0].Fields.ImageThumbnail != null)
                Console.WriteLine("SECTIONS.ImageThumbnail " + Tables.sections[0].Fields.ImageThumbnail[0].Filename);

            if (Tables.sections[0].Fields.ImagePoster != null)
                Console.WriteLine("SECTIONS.ImagePoster " + Tables.sections[0].Fields.ImagePoster[0].Filename);

            if (Tables.sections[0].Fields.Video != null)
                Console.WriteLine("SECTIONS.Video " + Tables.sections[0].Fields.Video[0].Filename);

            if (Tables.sections[0].Fields.TextReference != null)
                Console.WriteLine("SECTIONS.TextReference 0 length " + Tables.sections[0].Fields.TextReference.Length);
            */



            await ATGetText();

            /*
            var t = Tables.text.SingleOrDefault(t => t.Fields.Name == "txt-button-about");
            Console.WriteLine("TEXT.txt-button-about: " + t.Fields.En);
            */


            await ATGetGallery();


            /*
            Console.WriteLine("GALLERY.Name " + Tables.gallery[0].Fields.Name);
            Console.WriteLine("GALLERY.Publish " + Tables.gallery[0].Fields.Publish);
            Console.WriteLine("GALLERY.Notes " + Tables.gallery[0].Fields.Notes);
            Console.WriteLine("GALLERY.Button " + Tables.gallery[0].Fields.Button);
            Console.WriteLine("GALLERY.Header " + Tables.gallery[0].Fields.Header);
            Console.WriteLine("GALLERY.Body " + Tables.gallery[0].Fields.Body);
            Console.WriteLine("GALLERY.Icon " + Tables.gallery[0].Fields.Icon);


            if (Tables.gallery[0].Fields.Thumbnail != null)
                Console.WriteLine("GALLERY.Thumbnail 0 length " + Tables.gallery[0].Fields.Thumbnail.Length);

            if (Tables.gallery[0].Fields.Items != null)
                Console.WriteLine("GALLERY.Items 0 length " + Tables.gallery[0].Fields.Items.Length);

            if (Tables.gallery[0].Fields.Filter != null)
                Console.WriteLine("GALLERY.Filter 0 length " + Tables.gallery[0].Fields.Filter.Length);
            */



            await ATGetGalleryItem();

            /*
            Console.WriteLine("GALLERYITEM.Name " + Tables.galleryItem[0].Fields.Name);
            Console.WriteLine("GALLERYITEM.Notes " + Tables.galleryItem[0].Fields.Notes);
            Console.WriteLine("GALLERYITEM.Button " + Tables.galleryItem[0].Fields.Button);
            Console.WriteLine("GALLERYITEM.Header " + Tables.galleryItem[0].Fields.Header);
            Console.WriteLine("GALLERYITEM.Body " + Tables.galleryItem[0].Fields.Body);

            if (Tables.galleryItem[0].Fields.Item != null)
                Console.WriteLine("GALLERYITEM.Item " + Tables.galleryItem[0].Fields.Item[0].Filename);

            if (Tables.galleryItem[0].Fields.ReferenceGallery != null)
                Console.WriteLine("GALLERYITEM.ReferenceGallery 0 length " + Tables.galleryItem[0].Fields.ReferenceGallery.Length);

            if (Tables.galleryItem[0].Fields.ReferenceGalleryThumb != null)
                Console.WriteLine("GALLERYITEM.ReferenceGalleryThumb 0 length " + Tables.galleryItem[0].Fields.ReferenceGalleryThumb.Length);
            */



            await ATGetGlleryFilter();

            /*
            Console.WriteLine("GALLERYFILTER.Name " + Tables.galleryFilter[0].Fields.Name);
            Console.WriteLine("GALLERYFILTER.Notes " + Tables.galleryFilter[0].Fields.Notes);
            Console.WriteLine("GALLERYFILTER.Icon " + Tables.galleryFilter[0].Fields.Icon);

            if (Tables.galleryFilter[0].Fields.Gallery != null)
                Console.WriteLine("GALLERYFILTER.Gallery 0 length " + Tables.galleryFilter[0].Fields.Gallery.Length);
            */



            await ATGetAgenda();

            /*
            Console.WriteLine(Tables.agenda[1].Fields.Name);
            Console.WriteLine(Tables.agenda[1].Fields.Publish);
            Console.WriteLine(Tables.agenda[1].Fields.Location);
            Console.WriteLine(Tables.agenda[1].Fields.DateFrom);
            Console.WriteLine(Tables.agenda[1].Fields.DateTill);
            Console.WriteLine(Tables.agenda[1].Fields.Location);
            Console.WriteLine(Tables.agenda[1].Fields.Type);
            Console.WriteLine(Tables.agenda[1].Fields.Notes);
            */



            await ATGetContact();

            /*
            Console.WriteLine(Tables.contact[0].Fields.Name);
            Console.WriteLine(Tables.contact[0].Fields.Phone);
            Console.WriteLine(Tables.contact[0].Fields.PhoneIcon);
            Console.WriteLine(Tables.contact[0].Fields.Email);
            Console.WriteLine(Tables.contact[0].Fields.EmailIcon);
            Console.WriteLine(Tables.contact[0].Fields.Fb);
            Console.WriteLine(Tables.contact[0].Fields.FbIcon);
            Console.WriteLine(Tables.contact[0].Fields.Insta);
            Console.WriteLine(Tables.contact[0].Fields.InstaIcon);
            */



            await ATGetColors();

            /*
            Console.WriteLine(Tables.colors[0].Fields.Name);
            Console.WriteLine(Tables.colors[0].Fields.Hex);
            Console.WriteLine(Tables.colors[0].Fields.R);
            Console.WriteLine(Tables.colors[0].Fields.G);
            Console.WriteLine(Tables.colors[0].Fields.B);
            Console.WriteLine(Tables.colors[0].Fields.ImageIngredient);
            */

        }



        public static async Task SetAirtable()
        {
            //SET ALL TABLES + RECORDS TO AIRTABLE
            //status writing tables

            await GetAirtable();
        }
    }
}