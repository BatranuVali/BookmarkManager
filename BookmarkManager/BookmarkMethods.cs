using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookmarkManager
{

    internal class BookmarkMethods
    {
        internal List<Bookmark> bookmarks;
        internal Node parentNode;
        internal List<string> Folders;
        internal List<string> keys;
        internal BookmarkData bookmarkData;
        internal Rootobject roots;
        internal BookmarkMethods()
        {
            bookmarks = new List<Bookmark>();
            parentNode = new Node(null, "roots", null, new List<Node>());
            CreateFolders();
            roots = new Rootobject();
            keys = new List<string>();
        }
        internal void ConvertDeserializedToSerializationStructure(BookmarkData bookmarkData, dynamic newBookmark, string parentName, string deletedName,string deletedParent)
        {
            roots.checksum = bookmarkData.checksum;
            roots.version = bookmarkData.version;
            StartConversion(bookmarkData.roots, newBookmark, parentName,keys,deletedName,deletedParent);
        }

        internal void StartConversion(Dictionary<string, Bookmark> bookmarkDictionary, dynamic newBookmark, string parentName, List<string> keys, string deletedName, string deletedParent)
        {
            foreach (var key in keys)
            {
                foreach (var bookmarkPair in bookmarkDictionary)
                {
                    if (bookmarkPair.Key == key)
                    {
                        AddElements(key,bookmarkPair, newBookmark, parentName,deletedName,deletedParent);
                    }
                }
            }
        }
        private void AddElements(string key,dynamic bookmarkPair, dynamic newBookmark, string parentName, string deletedName, string deletedParent)
        {
            if (bookmarkPair.Value.name != deletedName)
            {
                if (bookmarkPair.Value.type == "url")
                {
                    URL url = new URL
                    {
                        name = bookmarkPair.Value.name,
                        date_added = bookmarkPair.Value.date_added,
                        date_last_used = bookmarkPair.Value.date_last_used,
                        id = bookmarkPair.Value.id,
                        guid = bookmarkPair.Value.guid,
                        type = bookmarkPair.Value.type,
                        url = bookmarkPair.Value.url
                    };
                    roots.roots.Add(key, url);
                }
                else
                {
                    Folder folder = new Folder
                    {
                        name = bookmarkPair.Value.name,
                        date_added = bookmarkPair.Value.date_added,
                        date_last_used = bookmarkPair.Value.date_last_used,
                        id = bookmarkPair.Value.id,
                        guid = bookmarkPair.Value.guid,
                        type = bookmarkPair.Value.type
                    };
                    roots.roots.Add(key, folder);

                    if (bookmarkPair.Value.name == parentName && parentName != null)
                    {
                        bookmarkPair.Value.children.Add(newBookmark);
                    }
                    if (bookmarkPair.Value.name == parentName&&parentName!=null)
                    {
                        PopulateFolderChildrenFromList(bookmarkPair.Value.children, folder, newBookmark, parentName, deletedName, deletedParent);
                        return;
                    }

                    if (bookmarkPair.Value.children != null)
                    {
                        PopulateFolderChildrenFromList(bookmarkPair.Value.children, folder, newBookmark, parentName, deletedName, deletedParent);
                    }
                }
            }
        }
        public void SaveBookmarks(string jsonFilePath)
        {
            try
            {
                var settings = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    Formatting = Formatting.Indented
                };
                string jsonString = JsonConvert.SerializeObject(roots, settings);
                File.WriteAllText(jsonFilePath, jsonString);
                Console.WriteLine("Bookmarks saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving bookmarks: {ex.Message}");
            }
        }



        private void PopulateFolderChildrenFromList(List<Bookmark> bookmarkList,Folder parent, dynamic newBookmark, string parentName, string deletedName, string deletedParent)
        {
                foreach (var bookmark in bookmarkList)
                {
                if (bookmark.name != deletedName)
                {
                    if (bookmark.type == "folder")
                    {
                        Folder child = new Folder();
                        child.name = bookmark.name;
                        child.date_added = bookmark.date_added;
                        child.date_last_used = bookmark.date_last_used;
                        child.id = bookmark.id;
                        child.guid = bookmark.guid;
                        child.type = bookmark.type;
                        parent.children.Add(child);

                        if (bookmark.children != null)
                        {
                            PopulateFolderChildrenFromList(bookmark.children, child, newBookmark, parentName, deletedName, deletedParent);
                        }
                    }
                    else
                    {
                        URL url = new URL();
                        url.name = bookmark.name;
                        url.date_added = bookmark.date_added;
                        url.date_last_used = bookmark.date_last_used;
                        url.id = bookmark.id;
                        url.guid = bookmark.guid;
                        url.type = bookmark.type;
                        url.url = bookmark.url;
                        parent.children.Add(url);
                    }
                }
                }
            if (parent.name == parentName)
            {
                parent.children.Add(newBookmark);
            }
        }
        private void CreateFolders()
        {
            Folders = new List<string>();
        }

        public void LoadBookmarks(string jsonFilePath)
        {
            try
            {
                string jsonString = File.ReadAllText(jsonFilePath);
                bookmarkData = JsonConvert.DeserializeObject<BookmarkData>(jsonString);
                PopulateBookmarksFromDictionary(bookmarkData.roots, parentNode);
                GetKeys(bookmarkData,keys);
                Console.WriteLine($"Number of bookmarks loaded: {bookmarks.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading bookmarks: {ex.Message}");
            }
        }

        private void GetKeys(BookmarkData bookmarkData,List<string>keys)
        {
            foreach(var key in bookmarkData.roots.Keys)
            {
                keys.Add(key);
            }
        }

        private void PopulateBookmarksFromDictionary(Dictionary<string, Bookmark> bookmarkDictionary, Node parentNode)
        {
            foreach (var bookmarkPair in bookmarkDictionary)
            {
                ProcessBookmark(bookmarkPair.Value);
                Node childNode = new Node(parentNode, bookmarkPair.Value.name, bookmarkPair.Value.url, new List<Node>());
                parentNode.children.Add(childNode);
                Console.WriteLine($"Created node: {childNode.name}");

                if (bookmarkPair.Value.type == "folder")
                {
                    Console.WriteLine($"Entering folder: {bookmarkPair.Value.name}");
                    if (bookmarkPair.Value.children != null)
                    {
                        Console.WriteLine($"Folder {bookmarkPair.Value.name} has {bookmarkPair.Value.children.Count} children");
                        PopulateChildrenFromList(bookmarkPair.Value.children, childNode);
                    }
                    else
                    {
                        Console.WriteLine($"Folder {bookmarkPair.Value.name} has no children");
                    }
                }
            }
        }

        private void PopulateChildrenFromList(List<Bookmark> bookmarkList, Node parentNode)
        {
            foreach (var bookmark in bookmarkList)
            {
                ProcessBookmark(bookmark);
                Node childNode = new Node(parentNode, bookmark.name, bookmark.url, new List<Node>());
                parentNode.children.Add(childNode);
                Console.WriteLine($"Created node: {childNode.name}");

                if (bookmark.type == "folder" && bookmark.children != null)
                {
                    PopulateChildrenFromList(bookmark.children, childNode);
                }
            }
        }


        private void ProcessBookmark(Bookmark bookmark)
        {
            bookmarks.Add(bookmark);
            Console.WriteLine("added bookmark");
        }
        public DataTable CreateDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("URL", typeof(string));

            PopulateDataTable(dataTable);

            return dataTable;
        }
        private void PopulateDataTable(DataTable dataTable)
        {
            foreach (var bookmark in bookmarks)
            {
                PopulateDataRow(bookmark, dataTable);

                if (bookmark.type == "folder" && bookmark.children != null)
                {
                    PopulateDataTable(bookmark.children, dataTable);
                }
            }
        }

        private void PopulateDataTable(List<Bookmark> bookmarkList, DataTable dataTable)
        {
            foreach (var bookmark in bookmarkList)
            {
                PopulateDataRow(bookmark, dataTable);

                if (bookmark.type == "folder" && bookmark.children != null)
                {
                    PopulateDataTable(bookmark.children, dataTable);
                }
            }
        }

        private void PopulateDataRow(Bookmark bookmark, DataTable dataTable)
        {
            if (bookmark.type == "url")
            {
                DataRow existingRow = dataTable.AsEnumerable().FirstOrDefault(row =>
                    row.Field<string>("Name") == bookmark.name && row.Field<string>("URL") == bookmark.url);

                if (existingRow == null)
                {
                    dataTable.Rows.Add(bookmark.name, bookmark.url);
                }
            }
        }

        internal void AddFolders(List<Bookmark> bookmarkList)
        {
            AddFoldersRecursive(bookmarkList);
            Folders = Folders.Distinct().OrderBy(folder => folder).ToList();
        }

        private void AddFoldersRecursive(List<Bookmark> bookmarkList)
        {
            Folders.Add(parentNode.name);

            foreach (var bookmark in bookmarkList)
            {
                if (bookmark.type == "folder")
                {
                    Folders.Add(bookmark.name);
                    AddFoldersRecursive(bookmark.children);
                }
            }
        }

    }
}
