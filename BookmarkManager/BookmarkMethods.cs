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
        private List<Bookmark> bookmarks;
        internal Node parentNode;

        public BookmarkMethods()
        {
            bookmarks = new List<Bookmark>();
            parentNode = new Node(null, "roots", null, new List<Node>());
        }
        public void LoadBookmarks(string jsonFilePath)
        {
            try
            {
                string jsonString = File.ReadAllText(jsonFilePath);
                BookmarkData bookmarkData = JsonConvert.DeserializeObject<BookmarkData>(jsonString);
                PopulateBookmarksFromDictionary(bookmarkData.roots,parentNode);
                Console.WriteLine($"Number of bookmarks loaded: {bookmarks.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading bookmarks: {ex.Message}");
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
    }
}
