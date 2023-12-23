using BookmarkManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BoomarkManager
{
    public partial class Tags : Form
    {
        public Alphabetical MainForm { get; set; }
        private BookmarkMethods bookmarkManager;

        public Tags()
        {
            InitializeComponent();
            bookmarkManager = new BookmarkMethods();
            this.FormClosing += Tags_FormClosing;
        }

        private void Tags_FormClosing1(object sender, FormClosingEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Tags_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void searchBar_Click(object sender, EventArgs e)
        {
        }

        private void searchBarInput_TextChanged(object sender, EventArgs e)
        {
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                Console.WriteLine($"Selected node: {e.Node.Text}, URL: {e.Node.Tag}");
            }
            else
            {
                Console.WriteLine($"Selected node: {e.Node.Text}");
            }
        }

        private void searchBar_Click_1(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void Tags_Load(object sender, EventArgs e)
        {

        }

        private void switchContext_Click_1(object sender, EventArgs e)
        {
            Alphabetical tagsForm = new Alphabetical();
            tagsForm.TagsForm = this;
            tagsForm.Show();
            this.Hide();
        }
    }
}