using BoomarkManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookmarkManager
{
    public partial class BookmarkAdd : Form
    {
        public Tags TagsForm { get; set; }
        private BookmarkMethods bookmarkManager;

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

        }
    }
}
