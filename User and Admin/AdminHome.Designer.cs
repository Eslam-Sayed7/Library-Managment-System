namespace Library_Managment_System
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.AdminDgridvLibrarybooks = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationYR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_windowName = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_user_name = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_sidebar = new System.Windows.Forms.Panel();
            this.Deletebook = new System.Windows.Forms.Button();
            this.DeleteUserBtn = new System.Windows.Forms.Button();
            this.Edit_info = new System.Windows.Forms.Button();
            this.AddBook = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Logout_admin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDgridvLibrarybooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.panel_sidebar.SuspendLayout();
            this.SuspendLayout();
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
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Controls.Add(this.AdminDgridvLibrarybooks);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(199, 55);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(861, 606);
            this.panel_main.TabIndex = 10;
            // 
            // AdminDgridvLibrarybooks
            // 
            this.AdminDgridvLibrarybooks.AllowUserToAddRows = false;
            this.AdminDgridvLibrarybooks.AllowUserToDeleteRows = false;
            this.AdminDgridvLibrarybooks.AllowUserToResizeColumns = false;
            this.AdminDgridvLibrarybooks.AllowUserToResizeRows = false;
            this.AdminDgridvLibrarybooks.BackgroundColor = System.Drawing.Color.White;
            this.AdminDgridvLibrarybooks.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.AdminDgridvLibrarybooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Poor Richard", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AdminDgridvLibrarybooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.AdminDgridvLibrarybooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminDgridvLibrarybooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.bookid,
            this.title,
            this.category,
            this.isbn,
            this.publicationYR,
            this.author,
            this.Update});
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Poor Richard", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AdminDgridvLibrarybooks.DefaultCellStyle = dataGridViewCellStyle39;
            this.AdminDgridvLibrarybooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminDgridvLibrarybooks.EnableHeadersVisualStyles = false;
            this.AdminDgridvLibrarybooks.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.AdminDgridvLibrarybooks.Location = new System.Drawing.Point(0, 0);
            this.AdminDgridvLibrarybooks.Name = "AdminDgridvLibrarybooks";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Poor Richard", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AdminDgridvLibrarybooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.AdminDgridvLibrarybooks.RowHeadersVisible = false;
            this.AdminDgridvLibrarybooks.RowHeadersWidth = 100;
            this.AdminDgridvLibrarybooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AdminDgridvLibrarybooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AdminDgridvLibrarybooks.Size = new System.Drawing.Size(861, 606);
            this.AdminDgridvLibrarybooks.StandardTab = true;
            this.AdminDgridvLibrarybooks.TabIndex = 9;
            this.AdminDgridvLibrarybooks.TabStop = false;
            this.AdminDgridvLibrarybooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminDgridvLibrarybooks_CellContentClick);
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            this.number.DefaultCellStyle = dataGridViewCellStyle32;
            this.number.DividerWidth = 2;
            this.number.HeaderText = "#";
            this.number.MinimumWidth = 2;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.number.Width = 41;
            // 
            // bookid
            // 
            this.bookid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.White;
            this.bookid.DefaultCellStyle = dataGridViewCellStyle33;
            this.bookid.DividerWidth = 2;
            this.bookid.HeaderText = "Book Id";
            this.bookid.Name = "bookid";
            this.bookid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bookid.Width = 64;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.Black;
            this.title.DefaultCellStyle = dataGridViewCellStyle34;
            this.title.DividerWidth = 2;
            this.title.HeaderText = "Book title";
            this.title.Name = "title";
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.Black;
            this.category.DefaultCellStyle = dataGridViewCellStyle35;
            this.category.DividerWidth = 2;
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            // 
            // isbn
            // 
            this.isbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            this.isbn.DefaultCellStyle = dataGridViewCellStyle36;
            this.isbn.DividerWidth = 2;
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            // 
            // publicationYR
            // 
            this.publicationYR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.Black;
            this.publicationYR.DefaultCellStyle = dataGridViewCellStyle37;
            this.publicationYR.DividerWidth = 2;
            this.publicationYR.HeaderText = "Publication year";
            this.publicationYR.Name = "publicationYR";
            // 
            // author
            // 
            this.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.Black;
            this.author.DefaultCellStyle = dataGridViewCellStyle38;
            this.author.DividerWidth = 2;
            this.author.HeaderText = "Author";
            this.author.Name = "author";
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 70;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(199, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 55);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(684, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "System Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_windowName
            // 
            this.panel_windowName.Location = new System.Drawing.Point(197, 3);
            this.panel_windowName.Name = "panel_windowName";
            this.panel_windowName.Size = new System.Drawing.Size(878, 55);
            this.panel_windowName.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(197, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 49);
            this.panel2.TabIndex = 1;
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
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Controls.Add(this.label_user_name);
            this.panel_logo.Controls.Add(this.panel4);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(199, 170);
            this.panel_logo.TabIndex = 2;
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel_sidebar.Controls.Add(this.Logout_admin);
            this.panel_sidebar.Controls.Add(this.button2);
            this.panel_sidebar.Controls.Add(this.Deletebook);
            this.panel_sidebar.Controls.Add(this.DeleteUserBtn);
            this.panel_sidebar.Controls.Add(this.Edit_info);
            this.panel_sidebar.Controls.Add(this.AddBook);
            this.panel_sidebar.Controls.Add(this.panel_logo);
            this.panel_sidebar.Controls.Add(this.panel2);
            this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidebar.Location = new System.Drawing.Point(0, 0);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Size = new System.Drawing.Size(199, 661);
            this.panel_sidebar.TabIndex = 7;
            // 
            // Deletebook
            // 
            this.Deletebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.Deletebook.Dock = System.Windows.Forms.DockStyle.Top;
            this.Deletebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebook.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebook.ForeColor = System.Drawing.Color.Transparent;
            this.Deletebook.Location = new System.Drawing.Point(0, 353);
            this.Deletebook.Name = "Deletebook";
            this.Deletebook.Size = new System.Drawing.Size(199, 62);
            this.Deletebook.TabIndex = 13;
            this.Deletebook.Text = "Delete Book";
            this.Deletebook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deletebook.UseVisualStyleBackColor = false;
            this.Deletebook.Click += new System.EventHandler(this.Deletebook_Click);
            // 
            // DeleteUserBtn
            // 
            this.DeleteUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.DeleteUserBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUserBtn.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUserBtn.ForeColor = System.Drawing.Color.Transparent;
            this.DeleteUserBtn.Location = new System.Drawing.Point(0, 291);
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.Size = new System.Drawing.Size(199, 62);
            this.DeleteUserBtn.TabIndex = 11;
            this.DeleteUserBtn.Text = "Delete user";
            this.DeleteUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteUserBtn.UseVisualStyleBackColor = false;
            this.DeleteUserBtn.Click += new System.EventHandler(this.DeleteUserBtn_Click);
            // 
            // Edit_info
            // 
            this.Edit_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.Edit_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.Edit_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_info.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_info.ForeColor = System.Drawing.Color.Transparent;
            this.Edit_info.Location = new System.Drawing.Point(0, 229);
            this.Edit_info.Name = "Edit_info";
            this.Edit_info.Size = new System.Drawing.Size(199, 62);
            this.Edit_info.TabIndex = 9;
            this.Edit_info.Text = "Edit Info";
            this.Edit_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit_info.UseVisualStyleBackColor = false;
            this.Edit_info.Click += new System.EventHandler(this.Edit_info_Click);
            // 
            // AddBook
            // 
            this.AddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.AddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBook.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBook.ForeColor = System.Drawing.Color.Transparent;
            this.AddBook.Location = new System.Drawing.Point(0, 170);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(199, 59);
            this.AddBook.TabIndex = 8;
            this.AddBook.Text = "Add Book";
            this.AddBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBook.UseVisualStyleBackColor = false;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(0, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 59);
            this.button2.TabIndex = 15;
            this.button2.Text = "Borrow action";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Logout_admin
            // 
            this.Logout_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.Logout_admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logout_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_admin.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_admin.ForeColor = System.Drawing.Color.Transparent;
            this.Logout_admin.Location = new System.Drawing.Point(0, 474);
            this.Logout_admin.Name = "Logout_admin";
            this.Logout_admin.Size = new System.Drawing.Size(199, 62);
            this.Logout_admin.TabIndex = 16;
            this.Logout_admin.Text = "Log Out";
            this.Logout_admin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout_admin.UseVisualStyleBackColor = false;
            this.Logout_admin.Click += new System.EventHandler(this.Logout_admin_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 661);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_windowName);
            this.Controls.Add(this.panel_sidebar);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdminDgridvLibrarybooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            this.panel_sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_windowName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_user_name;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_sidebar;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button Edit_info;
        private System.Windows.Forms.DataGridView AdminDgridvLibrarybooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookid;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicationYR;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.Button Deletebook;
        private System.Windows.Forms.Button DeleteUserBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Logout_admin;
    }
}