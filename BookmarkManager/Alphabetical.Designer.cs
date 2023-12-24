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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookmarkGrid = new System.Windows.Forms.DataGridView();
            this.switchContext = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInputBox = new System.Windows.Forms.TextBox();
            this.linkLabel = new System.Windows.Forms.Label();
            this.linkInputBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bookmarkGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(370, 36);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.MinimumSize = new System.Drawing.Size(175, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "TAG";
            // 
            // bookmarkGrid
            // 
            this.bookmarkGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookmarkGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.bookmarkGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookmarkGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookmarkGrid.GridColor = System.Drawing.Color.White;
            this.bookmarkGrid.Location = new System.Drawing.Point(2, 2);
            this.bookmarkGrid.Margin = new System.Windows.Forms.Padding(2);
            this.bookmarkGrid.Name = "bookmarkGrid";
            this.bookmarkGrid.RowHeadersWidth = 51;
            this.bookmarkGrid.RowTemplate.Height = 24;
            this.bookmarkGrid.Size = new System.Drawing.Size(733, 472);
            this.bookmarkGrid.TabIndex = 20;
            this.bookmarkGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookmarkGrid_CellContentClick_1);
            // 
            // switchContext
            // 
            this.switchContext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switchContext.AutoSize = true;
            this.switchContext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(205)))), ((int)(((byte)(160)))));
            this.switchContext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchContext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchContext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.switchContext.Location = new System.Drawing.Point(554, 70);
            this.switchContext.Margin = new System.Windows.Forms.Padding(2);
            this.switchContext.MinimumSize = new System.Drawing.Size(175, 31);
            this.switchContext.Name = "switchContext";
            this.switchContext.Size = new System.Drawing.Size(181, 31);
            this.switchContext.TabIndex = 19;
            this.switchContext.Text = "SWITCH CONTEXT";
            this.switchContext.UseVisualStyleBackColor = false;
            this.switchContext.Click += new System.EventHandler(this.switchContext_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.AutoSize = true;
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(205)))), ((int)(((byte)(160)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.deleteButton.Location = new System.Drawing.Point(370, 70);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.MinimumSize = new System.Drawing.Size(175, 31);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(180, 31);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // newButton
            // 
            this.newButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newButton.AutoSize = true;
            this.newButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(205)))), ((int)(((byte)(160)))));
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.newButton.Location = new System.Drawing.Point(186, 70);
            this.newButton.Margin = new System.Windows.Forms.Padding(2);
            this.newButton.MinimumSize = new System.Drawing.Size(175, 31);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(180, 31);
            this.newButton.TabIndex = 17;
            this.newButton.Text = "NEW";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.AutoSize = true;
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(205)))), ((int)(((byte)(160)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.saveButton.Location = new System.Drawing.Point(2, 70);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.MinimumSize = new System.Drawing.Size(175, 31);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(180, 31);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(186, 0);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(180, 13);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "NAME";
            // 
            // nameInputBox
            // 
            this.nameInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameInputBox.Location = new System.Drawing.Point(186, 36);
            this.nameInputBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameInputBox.MinimumSize = new System.Drawing.Size(175, 20);
            this.nameInputBox.Name = "nameInputBox";
            this.nameInputBox.Size = new System.Drawing.Size(180, 20);
            this.nameInputBox.TabIndex = 14;
            this.nameInputBox.TextChanged += new System.EventHandler(this.nameInputBox_TextChanged);
            // 
            // linkLabel
            // 
            this.linkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.Location = new System.Drawing.Point(2, 0);
            this.linkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(180, 13);
            this.linkLabel.TabIndex = 13;
            this.linkLabel.Text = "LINK";
            // 
            // linkInputBox
            // 
            this.linkInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkInputBox.Location = new System.Drawing.Point(2, 36);
            this.linkInputBox.Margin = new System.Windows.Forms.Padding(2);
            this.linkInputBox.MinimumSize = new System.Drawing.Size(175, 20);
            this.linkInputBox.Name = "linkInputBox";
            this.linkInputBox.Size = new System.Drawing.Size(180, 20);
            this.linkInputBox.TabIndex = 12;
            this.linkInputBox.TextChanged += new System.EventHandler(this.linkInputBox_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.switchContext, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.deleteButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.newButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.saveButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameInputBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkInputBox, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(737, 104);
            this.tableLayoutPanel1.TabIndex = 23;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.bookmarkGrid, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 143);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(737, 476);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // Alphabetical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(205)))), ((int)(((byte)(160)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "Alphabetical";
            this.Text = "Bookmark Manager";
            this.Load += new System.EventHandler(this.Alphabetical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookmarkGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView bookmarkGrid;
        private System.Windows.Forms.Button switchContext;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInputBox;
        private System.Windows.Forms.Label linkLabel;
        private System.Windows.Forms.TextBox linkInputBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

