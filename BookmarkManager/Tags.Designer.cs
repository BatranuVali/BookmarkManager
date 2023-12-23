namespace BoomarkManager
{
    partial class Tags
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
            this.searchBar = new System.Windows.Forms.Label();
            this.searchBarInput = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.switchContext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBar
            // 
            this.searchBar.AutoSize = true;
            this.searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(277, 38);
            this.searchBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(63, 18);
            this.searchBar.TabIndex = 15;
            this.searchBar.Text = "Search :";
            // 
            // searchBarInput
            // 
            this.searchBarInput.Location = new System.Drawing.Point(340, 38);
            this.searchBarInput.Margin = new System.Windows.Forms.Padding(2);
            this.searchBarInput.Name = "searchBarInput";
            this.searchBarInput.Size = new System.Drawing.Size(172, 20);
            this.searchBarInput.TabIndex = 14;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.treeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(205)))), ((int)(((byte)(160)))));
            this.treeView1.Location = new System.Drawing.Point(42, 85);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.MinimumSize = new System.Drawing.Size(470, 326);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(470, 326);
            this.treeView1.TabIndex = 13;
            // 
            // switchContext
            // 
            this.switchContext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(205)))), ((int)(((byte)(160)))));
            this.switchContext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchContext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchContext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.switchContext.Location = new System.Drawing.Point(42, 32);
            this.switchContext.Margin = new System.Windows.Forms.Padding(2);
            this.switchContext.Name = "switchContext";
            this.switchContext.Size = new System.Drawing.Size(171, 31);
            this.switchContext.TabIndex = 12;
            this.switchContext.Text = "SWITCH CONTEXT";
            this.switchContext.UseVisualStyleBackColor = false;
            // 
            // Tags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(555, 452);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.searchBarInput);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.switchContext);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(205)))), ((int)(((byte)(160)))));
            this.Name = "Tags";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchBar;
        private System.Windows.Forms.TextBox searchBarInput;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button switchContext;
    }
}