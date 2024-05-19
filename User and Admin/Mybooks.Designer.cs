namespace Library_Managment_System
{
    partial class Mybooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LowerPaner = new System.Windows.Forms.Panel();
            this.LabelMybooks = new System.Windows.Forms.Label();
            this.DgridvMybooks = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowerPaner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgridvMybooks)).BeginInit();
            this.SuspendLayout();
            // 
            // LowerPaner
            // 
            this.LowerPaner.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LowerPaner.Controls.Add(this.LabelMybooks);
            this.LowerPaner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LowerPaner.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LowerPaner.Location = new System.Drawing.Point(0, 526);
            this.LowerPaner.Name = "LowerPaner";
            this.LowerPaner.Size = new System.Drawing.Size(937, 55);
            this.LowerPaner.TabIndex = 6;
            // 
            // LabelMybooks
            // 
            this.LabelMybooks.AutoSize = true;
            this.LabelMybooks.BackColor = System.Drawing.SystemColors.Menu;
            this.LabelMybooks.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMybooks.Location = new System.Drawing.Point(230, 17);
            this.LabelMybooks.Name = "LabelMybooks";
            this.LabelMybooks.Size = new System.Drawing.Size(470, 29);
            this.LabelMybooks.TabIndex = 0;
            this.LabelMybooks.Text = "Here You can find your borrowed books ";
            // 
            // DgridvMybooks
            // 
            this.DgridvMybooks.AllowUserToAddRows = false;
            this.DgridvMybooks.AllowUserToDeleteRows = false;
            this.DgridvMybooks.AllowUserToResizeColumns = false;
            this.DgridvMybooks.AllowUserToResizeRows = false;
            this.DgridvMybooks.BackgroundColor = System.Drawing.Color.White;
            this.DgridvMybooks.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DgridvMybooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgridvMybooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgridvMybooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgridvMybooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.Title,
            this.Category,
            this.ISBN,
            this.ReturnDate});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgridvMybooks.DefaultCellStyle = dataGridViewCellStyle7;
            this.DgridvMybooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgridvMybooks.EnableHeadersVisualStyles = false;
            this.DgridvMybooks.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DgridvMybooks.Location = new System.Drawing.Point(0, 0);
            this.DgridvMybooks.Name = "DgridvMybooks";
            this.DgridvMybooks.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgridvMybooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgridvMybooks.RowHeadersVisible = false;
            this.DgridvMybooks.RowHeadersWidth = 100;
            this.DgridvMybooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgridvMybooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgridvMybooks.Size = new System.Drawing.Size(937, 526);
            this.DgridvMybooks.StandardTab = true;
            this.DgridvMybooks.TabIndex = 7;
            this.DgridvMybooks.TabStop = false;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            this.number.DefaultCellStyle = dataGridViewCellStyle2;
            this.number.DividerWidth = 5;
            this.number.FillWeight = 10F;
            this.number.HeaderText = "#";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.number.Width = 47;
            // 
            // Title
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Title.DefaultCellStyle = dataGridViewCellStyle3;
            this.Title.DividerWidth = 5;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Category
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Category.DefaultCellStyle = dataGridViewCellStyle4;
            this.Category.DividerWidth = 5;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // ISBN
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.ISBN.DefaultCellStyle = dataGridViewCellStyle5;
            this.ISBN.DividerWidth = 5;
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // ReturnDate
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.ReturnDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.ReturnDate.DividerWidth = 5;
            this.ReturnDate.HeaderText = "Return Date";
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            // 
            // Mybooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 581);
            this.Controls.Add(this.DgridvMybooks);
            this.Controls.Add(this.LowerPaner);
            this.Name = "Mybooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mybooks";
            this.LowerPaner.ResumeLayout(false);
            this.LowerPaner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgridvMybooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LowerPaner;
        private System.Windows.Forms.DataGridView DgridvMybooks;
        private System.Windows.Forms.Label LabelMybooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
    }
}