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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LowerPaner = new System.Windows.Forms.Panel();
            this.LabelMybooks = new System.Windows.Forms.Label();
            this.DgridvMybooks = new System.Windows.Forms.DataGridView();
            this.Transaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.LabelMybooks.Location = new System.Drawing.Point(12, 17);
            this.LabelMybooks.Name = "LabelMybooks";
            this.LabelMybooks.Size = new System.Drawing.Size(470, 29);
            this.LabelMybooks.TabIndex = 0;
            this.LabelMybooks.Text = "Here You can find your borrowed books ";
            // 
            // DgridvMybooks
            // 
            this.DgridvMybooks.BackgroundColor = System.Drawing.Color.White;
            this.DgridvMybooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgridvMybooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgridvMybooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgridvMybooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Transaction,
            this.Title,
            this.Category,
            this.ISBN,
            this.ReturnDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgridvMybooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgridvMybooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgridvMybooks.EnableHeadersVisualStyles = false;
            this.DgridvMybooks.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgridvMybooks.Location = new System.Drawing.Point(0, 0);
            this.DgridvMybooks.Name = "DgridvMybooks";
            this.DgridvMybooks.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgridvMybooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgridvMybooks.RowHeadersVisible = false;
            this.DgridvMybooks.Size = new System.Drawing.Size(937, 526);
            this.DgridvMybooks.StandardTab = true;
            this.DgridvMybooks.TabIndex = 7;
            this.DgridvMybooks.TabStop = false;
            // 
            // Transaction
            // 
            this.Transaction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Transaction.HeaderText = "Transaction";
            this.Transaction.Name = "Transaction";
            this.Transaction.ReadOnly = true;
            this.Transaction.Width = 118;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // ReturnDate
            // 
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
    }
}