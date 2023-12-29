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
        internal List<string> Folders;

        public Tags()
        {
            InitializeComponent();
            bookmarkManager = new BookmarkMethods();
            this.FormClosing += Tags_FormClosing;
            this.treeView1.NodeMouseClick += TreeView1_NodeMouseClick;
        }

        private void Tags_Load(object sender, EventArgs e)
        {
            bookmarkManager.LoadBookmarks("Bookmarks.json");
            PopulateTreeView(treeView1, bookmarkManager.parentNode);
            bookmarkManager.AddFolders(bookmarkManager.bookmarks);
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

        private void searchBar_Click_1(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void switchContext_Click_1(object sender, EventArgs e)
        {
            Alphabetical tagsForm = new Alphabetical();
            tagsForm.TagsForm = this;
            tagsForm.Show();
            this.Hide();
        }

        private void PopulateTreeView(System.Windows.Forms.TreeView treeView, Node rootNode)
        {

            TreeNode rootTreeNode = new TreeNode(rootNode.name);
            rootTreeNode.Tag = rootNode;


            treeView.Nodes.Add(rootTreeNode);


            AddChildTreeNodes(rootTreeNode, rootNode.children);
        }

        private void AddChildTreeNodes(TreeNode parentTreeNode, List<Node> childNodes)
        {
            foreach (Node childNode in childNodes)
            {
                TreeNode childTreeNode = new TreeNode(childNode.name);

                childTreeNode.Tag = childNode;

                parentTreeNode.Nodes.Add(childTreeNode);

                if (childNode.children.Count > 0)
                {
                    AddChildTreeNodes(childTreeNode, childNode.children);
                }
            }
        }
        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Node node = (Node)e.Node.Tag;

            if (!string.IsNullOrEmpty(node.url))
            {
                System.Diagnostics.Process.Start(node.url);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            BookmarkAdd addForm = new BookmarkAdd();
            addForm.TagsForm = this;
            addForm.Show();
        }


    }
}