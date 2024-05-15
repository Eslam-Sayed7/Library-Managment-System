namespace Library_Managment_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_sidebar = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_favorite = new System.Windows.Forms.Button();
            this.btn_My_books = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_user_name = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_windowName = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.DgridvLibrarybooks = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationYR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_sidebar.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgridvLibrarybooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.Controls.Add(this.LogoutBtn);
            this.panel_sidebar.Controls.Add(this.btn_settings);
            this.panel_sidebar.Controls.Add(this.btn_favorite);
            this.panel_sidebar.Controls.Add(this.btn_My_books);
            this.panel_sidebar.Controls.Add(this.panel_logo);
            this.panel_sidebar.Controls.Add(this.panel2);
            this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidebar.Location = new System.Drawing.Point(0, 0);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Size = new System.Drawing.Size(199, 661);
            this.panel_sidebar.TabIndex = 0;
            this.panel_sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Location = new System.Drawing.Point(0, 356);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(199, 62);
            this.LogoutBtn.TabIndex = 6;
            this.LogoutBtn.Text = "Log out";
            this.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.logout_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Location = new System.Drawing.Point(0, 294);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(199, 62);
            this.btn_settings.TabIndex = 5;
            this.btn_settings.Text = "Settings";
            this.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.UseVisualStyleBackColor = true;
            // 
            // btn_favorite
            // 
            this.btn_favorite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_favorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_favorite.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_favorite.ForeColor = System.Drawing.Color.Transparent;
            this.btn_favorite.Location = new System.Drawing.Point(0, 232);
            this.btn_favorite.Name = "btn_favorite";
            this.btn_favorite.Size = new System.Drawing.Size(199, 62);
            this.btn_favorite.TabIndex = 4;
            this.btn_favorite.Text = "Favourite";
            this.btn_favorite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_favorite.UseVisualStyleBackColor = true;
            // 
            // btn_My_books
            // 
            this.btn_My_books.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_My_books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_My_books.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_My_books.ForeColor = System.Drawing.Color.Transparent;
            this.btn_My_books.Location = new System.Drawing.Point(0, 170);
            this.btn_My_books.Name = "btn_My_books";
            this.btn_My_books.Size = new System.Drawing.Size(199, 62);
            this.btn_My_books.TabIndex = 3;
            this.btn_My_books.Text = "My Books";
            this.btn_My_books.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_My_books.UseVisualStyleBackColor = true;
            this.btn_My_books.Click += new System.EventHandler(this.btn_My_books_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Controls.Add(this.label_user_name);
            this.panel_logo.Controls.Add(this.panel4);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(199, 170);
            this.panel_logo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 125);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label_user_name
            // 
            this.label_user_name.AutoSize = true;
            this.label_user_name.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_user_name.Location = new System.Drawing.Point(58, 141);
            this.label_user_name.Name = "label_user_name";
            this.label_user_name.Size = new System.Drawing.Size(76, 19);
            this.label_user_name.TabIndex = 0;
            this.label_user_name.Text = "User Name";
            this.label_user_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(984, 46);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(197, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 49);
            this.panel2.TabIndex = 1;
            // 
            // panel_windowName
            // 
            this.panel_windowName.Location = new System.Drawing.Point(200, 3);
            this.panel_windowName.Name = "panel_windowName";
            this.panel_windowName.Size = new System.Drawing.Size(981, 55);
            this.panel_windowName.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(199, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 55);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(459, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Controls.Add(this.DgridvLibrarybooks);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(199, 55);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(985, 606);
            this.panel_main.TabIndex = 6;
            // 
            // DgridvLibrarybooks
            // 
            this.DgridvLibrarybooks.AllowUserToAddRows = false;
            this.DgridvLibrarybooks.AllowUserToDeleteRows = false;
            this.DgridvLibrarybooks.AllowUserToResizeColumns = false;
            this.DgridvLibrarybooks.AllowUserToResizeRows = false;
            this.DgridvLibrarybooks.BackgroundColor = System.Drawing.Color.White;
            this.DgridvLibrarybooks.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DgridvLibrarybooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poor Richard", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgridvLibrarybooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgridvLibrarybooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgridvLibrarybooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.bookid,
            this.title,
            this.category,
            this.isbn,
            this.publicationYR,
            this.author});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poor Richard", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgridvLibrarybooks.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgridvLibrarybooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgridvLibrarybooks.EnableHeadersVisualStyles = false;
            this.DgridvLibrarybooks.Location = new System.Drawing.Point(0, 0);
            this.DgridvLibrarybooks.Name = "DgridvLibrarybooks";
            this.DgridvLibrarybooks.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poor Richard", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgridvLibrarybooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgridvLibrarybooks.RowHeadersVisible = false;
            this.DgridvLibrarybooks.RowHeadersWidth = 100;
            this.DgridvLibrarybooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgridvLibrarybooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgridvLibrarybooks.Size = new System.Drawing.Size(985, 606);
            this.DgridvLibrarybooks.StandardTab = true;
            this.DgridvLibrarybooks.TabIndex = 8;
            this.DgridvLibrarybooks.TabStop = false;
            // 
            // number
            // 
            this.number.HeaderText = "#";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // bookid
            // 
            this.bookid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.bookid.DefaultCellStyle = dataGridViewCellStyle2;
            this.bookid.HeaderText = "Book Id";
            this.bookid.Name = "bookid";
            this.bookid.ReadOnly = true;
            this.bookid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bookid.Width = 62;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.HeaderText = "Book title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // isbn
            // 
            this.isbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            // 
            // publicationYR
            // 
            this.publicationYR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.publicationYR.HeaderText = "Publication year";
            this.publicationYR.Name = "publicationYR";
            this.publicationYR.ReadOnly = true;
            // 
            // author
            // 
            this.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.author.HeaderText = "Author";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_windowName);
            this.Controls.Add(this.panel_sidebar);
            this.Font = new System.Drawing.Font("Poor Richard", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_sidebar.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgridvLibrarybooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_windowName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button btn_My_books;
        private System.Windows.Forms.Button btn_favorite;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Label label_user_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DgridvLibrarybooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookid;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicationYR;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
    }
}

