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
    public partial class Alphabetical : Form
    {
        public Tags TagsForm { get; set; }

        DataTable bookmarkDT = new DataTable();
        public Alphabetical instance;
        internal BookmarkMethods bookmarkManager;

        public Alphabetical()
        {
            InitializeComponent();
            instance = this;
            bookmarkManager = new BookmarkMethods();
            LoadBookmarksAndPopulateTable();
            this.FormClosing += Bokmark_FormClosing;
        }

        private void Bokmark_Load(object sender, EventArgs e)
        {
            bookmarkGrid.DataSource = bookmarkDT.DefaultView;
        }

        private void linkInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            String name = nameInputBox.Text;
            String link = linkInputBox.Text;
            bookmarkDT.Rows.Add(link, name);
            newButton_Click(sender, e);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            linkInputBox.Text = "";
            nameInputBox.Text = "";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                bookmarkDT.Rows[bookmarkGrid.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Bokmark_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void switchContext_Click(object sender, EventArgs e)
        {
            Tags tagsForm = new Tags();
            tagsForm.MainForm = this;
            tagsForm.Show();
            this.Hide();
        }

        private void bookmarkGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                nameInputBox.Text = bookmarkDT.Rows[bookmarkGrid.CurrentCell.RowIndex].ItemArray[0].ToString();
                linkInputBox.Text = bookmarkDT.Rows[bookmarkGrid.CurrentCell.RowIndex].ItemArray[1].ToString();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void bookmarkGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                string url = bookmarkDT.Rows[e.RowIndex].ItemArray[1].ToString();
                System.Diagnostics.Process.Start(url);
            }
        }

        private void LoadBookmarksAndPopulateTable()
        {
            string jsonFilePath = "Bookmarks.json";
            bookmarkManager.LoadBookmarks(jsonFilePath);
            PopulateDataTable();
            SortDataTable("Name");
            bookmarkGrid.DataSource = bookmarkDT.DefaultView;
        }

        private void SortDataTable(string columnName)
        {
            if (bookmarkDT.Rows.Count > 0)
            {
                DataView dataView = bookmarkDT.DefaultView;
                dataView.Sort = columnName;
                bookmarkDT = dataView.ToTable();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void PopulateDataTable()
        {
            bookmarkDT.Clear();
            bookmarkDT.Merge(bookmarkManager.CreateDataTable());
        }

        private void Alphabetical_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bookmarkGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1) 
            {
                string url = bookmarkDT.Rows[e.RowIndex].ItemArray[1].ToString();
                try
                {
                    System.Diagnostics.Process.Start(url);
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }

        }

    }
}
