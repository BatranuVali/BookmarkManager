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
        public BookmarkMethods()
        {
            bookmarks = new List<Bookmark>();
        }
        public void LoadBookmarks(string jsonFilePath)
        {
            try
            {
                string jsonString = File.ReadAllText(jsonFilePath);
                BookmarkData bookmarkData = JsonConvert.DeserializeObject<BookmarkData>(jsonString);
                PopulateBookmarksFromDictionary(bookmarkData.roots);
                Console.WriteLine($"Number of bookmarks loaded: {bookmarks.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading bookmarks: {ex.Message}");
            }
        }
        private void PopulateBookmarksFromList(List<Bookmark> bookmarkList)
        {
            int i = 0;
            foreach (var bookmark in bookmarkList)
            {
                ProcessBookmark(bookmark);

                if (bookmark.type == "folder")
                {
                    i++;
                    Console.WriteLine($"Entering folder: {bookmark.name}");

                    if (bookmark.children != null)
                    {
                        Console.WriteLine($"Folder {bookmark.name} has {bookmark.children.Count} children");
                        PopulateBookmarksFromList(bookmark.children);
                    }
                    else
                    {
                        Console.WriteLine($"Folder {bookmark.name} has no children");
                    }
                }
            }
            Console.WriteLine($"You entered the loop {i} times");
        }

        private void PopulateBookmarksFromDictionary(Dictionary<string, Bookmark> bookmarkDictionary)
        {
            foreach (var bookmarkPair in bookmarkDictionary)
            {
                ProcessBookmark(bookmarkPair.Value);

                if (bookmarkPair.Value.type == "folder")
                {
                    Console.WriteLine($"Entering folder: {bookmarkPair.Value.name}");

                    if (bookmarkPair.Value.children != null)
                    {
                        Console.WriteLine($"Folder {bookmarkPair.Value.name} has {bookmarkPair.Value.children.Count} children");
                        PopulateBookmarksFromList(bookmarkPair.Value.children);
                    }
                    else
                    {
                        Console.WriteLine($"Folder {bookmarkPair.Value.name} has no children");
                    }
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
                    // Recursively process subfolders
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
                    // Recursively process subfolders
                }
            }
        }

        private void PopulateDataRow(Bookmark bookmark, DataTable dataTable)
        {
            if (bookmark.type == "url")
            {
                dataTable.Rows.Add(bookmark.name, bookmark.url);
            }
        }
    }
}
