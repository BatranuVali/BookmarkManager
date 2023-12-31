using BoomarkManager;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BookmarkManager
{
    public partial class BookmarkAdd : Form
    {
        public Tags TagsForm { get; set; }
        private BookmarkMethods bookmarkManager;
        internal Bookmark newBookmark = new Bookmark();
        internal List<string> Folders => bookmarkManager.Folders;

        internal BookmarkAdd(BookmarkMethods bookmarkManager)
        {
            InitializeComponent();
            this.bookmarkManager = bookmarkManager;
            bookmarkManager.AddFolders(bookmarkManager.bookmarks);
            PopulateType();
            PopulateParents();
            this.FormClosing += Add_FormClosing;
        }

        private void Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
        private void nameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void URLinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void parentSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void PopulateType()
        {
            List<string> items = new List<string>() { "Folder", "URL" };
            typeSelect.Items.AddRange(items.ToArray());
            typeSelect.SelectedIndex = 0;
        }
        private void PopulateParents()
        {
            parentSelect.Items.Clear();
            parentSelect.Items.AddRange(Folders.ToArray());
            parentSelect.SelectedIndex = 0;
        }
        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveButton_Click(sender, e, typeSelect);
        }

        private void saveButton_Click(object sender, EventArgs e, ComboBox typeSelect)
        {
            newBookmark.name = nameInput.Text;
            newBookmark.type = typeSelect.SelectedItem.ToString();
            if (typeSelect.SelectedIndex == 1) { newBookmark.url = URLinput.Text; }
            else newBookmark.url = null;
            FindParentAndAddNewBookmark(newBookmark);
            AddNewBookmark(bookmarkManager.bookmarkData.roots["roots"], newBookmark);
            DeleteSurplusOfKeys();
            SaveBookmarks("Bookmarks.json");
        }

        private void DeleteSurplusOfKeys()
        {
            List<string> keysToRemove = new List<string>();
            foreach (var key in bookmarkManager.bookmarkData.roots.Keys)
            {
                if (key != "roots")
                {
                    keysToRemove.Add(key);
                }
            }
            foreach (var key in keysToRemove)
            {
                bookmarkManager.bookmarkData.roots.Remove(key);
            }
        }
        private void FindParentAndAddNewBookmark(Bookmark bookmark)
        {
            foreach (var parent in bookmarkManager.bookmarks)
            {
                if (parent.name == parentSelect.SelectedItem.ToString())
                {
                    parent.children.Add(bookmark);
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

                bookmarkManager.bookmarkData.roots["roots"].children = bookmarkManager.bookmarks;

                string jsonString = JsonConvert.SerializeObject(bookmarkManager.bookmarkData, settings);
                File.WriteAllText(jsonFilePath, jsonString);
                Console.WriteLine("Bookmarks saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving bookmarks: {ex.Message}");
            }
        }


        private void AddNewBookmark(Bookmark parentBookmark, Bookmark newBookmark)
        {
            if (parentBookmark.name == parentSelect.SelectedItem.ToString())
            {
                parentBookmark.children.Add(newBookmark);
                return;
            }

            if (parentBookmark.children != null)
            {
                foreach (var childBookmark in parentBookmark.children)
                {
                    AddNewBookmark(childBookmark, newBookmark);
                }
            }
        }


    }
}