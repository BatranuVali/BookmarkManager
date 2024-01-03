namespace BookmarkManager
{
    partial class Alphabetical
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alphabetical));
            this.bookmarkGrid = new System.Windows.Forms.DataGridView();
            this.switchContext = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.searchBar = new System.Windows.Forms.Label();
            this.searchBarInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bookmarkGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookmarkGrid
            // 
            this.bookmarkGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookmarkGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.bookmarkGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookmarkGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookmarkGrid.GridColor = System.Drawing.Color.White;
            this.bookmarkGrid.Location = new System.Drawing.Point(2, 41);
            this.bookmarkGrid.Margin = new System.Windows.Forms.Padding(2);
            this.bookmarkGrid.Name = "bookmarkGrid";
            this.bookmarkGrid.RowHeadersWidth = 51;
            this.bookmarkGrid.RowTemplate.Height = 24;
            this.bookmarkGrid.Size = new System.Drawing.Size(510, 348);
            this.bookmarkGrid.TabIndex = 20;
            this.bookmarkGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookmarkGrid_CellContentClick_1);
            // 
            // switchContext
            // 
            this.switchContext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.switchContext.AutoSize = true;
            this.switchContext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(205)))), ((int)(((byte)(160)))));
            this.switchContext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchContext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchContext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.switchContext.Location = new System.Drawing.Point(2, 2);
            this.switchContext.Margin = new System.Windows.Forms.Padding(2);
            this.switchContext.MinimumSize = new System.Drawing.Size(175, 31);
            this.switchContext.Name = "switchContext";
            this.switchContext.Size = new System.Drawing.Size(175, 31);
            this.switchContext.TabIndex = 19;
            this.switchContext.Text = "TREE VIEW";
            this.switchContext.UseVisualStyleBackColor = false;
            this.switchContext.Click += new System.EventHandler(this.switchContext_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.switchContext, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(508, 33);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.searchBarInput, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.searchBar, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(257, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(248, 27);
            this.tableLayoutPanel4.TabIndex = 27;
            // 
            // searchBar
            // 
            this.searchBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchBar.AutoSize = true;
            this.searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(59, 4);
            this.searchBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(63, 18);
            this.searchBar.TabIndex = 15;
            this.searchBar.Text = "Search :";
            this.searchBar.Click += new System.EventHandler(this.searchBar_Click);
            // 
            // searchBarInput
            // 
            this.searchBarInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBarInput.Location = new System.Drawing.Point(126, 3);
            this.searchBarInput.Margin = new System.Windows.Forms.Padding(2);
            this.searchBarInput.Name = "searchBarInput";
            this.searchBarInput.Size = new System.Drawing.Size(120, 20);
            this.searchBarInput.TabIndex = 14;
            this.searchBarInput.TextChanged += new System.EventHandler(this.searchBarInput_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.bookmarkGrid, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(514, 391);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // Alphabetical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(514, 391);
            this.Controls.Add(this.tableLayoutPanel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(205)))), ((int)(((byte)(160)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(530, 430);
            this.Name = "Alphabetical";
            this.Text = "Bookmark Manager";
            this.Load += new System.EventHandler(this.Alphabetical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookmarkGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView bookmarkGrid;
        private System.Windows.Forms.Button switchContext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox searchBarInput;
        private System.Windows.Forms.Label searchBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

