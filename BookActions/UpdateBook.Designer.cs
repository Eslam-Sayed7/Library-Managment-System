namespace Library_Managment_System
{
    partial class UpdateBook
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
            this.Updatebtn = new System.Windows.Forms.Button();
            this.AvailableBox1 = new System.Windows.Forms.ComboBox();
            this.updateEdition = new System.Windows.Forms.TextBox();
            this.updateDescBox = new System.Windows.Forms.TextBox();
            this.UpdateBookpubYr = new System.Windows.Forms.TextBox();
            this.updateBookISBN = new System.Windows.Forms.TextBox();
            this.updateBookTitle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ComboAuthorID = new System.Windows.Forms.ComboBox();
            this.ComboCategoryId = new System.Windows.Forms.ComboBox();
            this.BacktohomeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(442, 82);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(75, 37);
            this.Updatebtn.TabIndex = 49;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Update_btn_click);
            // 
            // AvailableBox1
            // 
            this.AvailableBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AvailableBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableBox1.FormattingEnabled = true;
            this.AvailableBox1.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.AvailableBox1.Location = new System.Drawing.Point(142, 261);
            this.AvailableBox1.Name = "AvailableBox1";
            this.AvailableBox1.Size = new System.Drawing.Size(121, 26);
            this.AvailableBox1.TabIndex = 48;
            // 
            // updateEdition
            // 
            this.updateEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEdition.Location = new System.Drawing.Point(142, 338);
            this.updateEdition.Name = "updateEdition";
            this.updateEdition.Size = new System.Drawing.Size(250, 35);
            this.updateEdition.TabIndex = 46;
            // 
            // updateDescBox
            // 
            this.updateDescBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDescBox.Location = new System.Drawing.Point(142, 297);
            this.updateDescBox.Name = "updateDescBox";
            this.updateDescBox.Size = new System.Drawing.Size(250, 35);
            this.updateDescBox.TabIndex = 45;
            // 
            // UpdateBookpubYr
            // 
            this.UpdateBookpubYr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBookpubYr.Location = new System.Drawing.Point(140, 212);
            this.UpdateBookpubYr.Name = "UpdateBookpubYr";
            this.UpdateBookpubYr.Size = new System.Drawing.Size(250, 35);
            this.UpdateBookpubYr.TabIndex = 44;
            // 
            // updateBookISBN
            // 
            this.updateBookISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBookISBN.Location = new System.Drawing.Point(141, 124);
            this.updateBookISBN.Name = "updateBookISBN";
            this.updateBookISBN.Size = new System.Drawing.Size(250, 35);
            this.updateBookISBN.TabIndex = 42;
            // 
            // updateBookTitle
            // 
            this.updateBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBookTitle.Location = new System.Drawing.Point(140, 83);
            this.updateBookTitle.Name = "updateBookTitle";
            this.updateBookTitle.Size = new System.Drawing.Size(250, 35);
            this.updateBookTitle.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 18);
            this.label10.TabIndex = 40;
            this.label10.Text = "Author";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 39;
            this.label9.Text = "Edition";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "availability";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "PublicationYear";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Title";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 31);
            this.label11.TabIndex = 30;
            this.label11.Text = "Update Book";
            // 
            // ComboAuthorID
            // 
            this.ComboAuthorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboAuthorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboAuthorID.FormattingEnabled = true;
            this.ComboAuthorID.Location = new System.Drawing.Point(140, 379);
            this.ComboAuthorID.Name = "ComboAuthorID";
            this.ComboAuthorID.Size = new System.Drawing.Size(170, 26);
            this.ComboAuthorID.TabIndex = 51;
            // 
            // ComboCategoryId
            // 
            this.ComboCategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCategoryId.FormattingEnabled = true;
            this.ComboCategoryId.Location = new System.Drawing.Point(140, 173);
            this.ComboCategoryId.Name = "ComboCategoryId";
            this.ComboCategoryId.Size = new System.Drawing.Size(170, 26);
            this.ComboCategoryId.TabIndex = 52;
            // 
            // BacktohomeBtn
            // 
            this.BacktohomeBtn.Location = new System.Drawing.Point(442, 176);
            this.BacktohomeBtn.Name = "BacktohomeBtn";
            this.BacktohomeBtn.Size = new System.Drawing.Size(75, 37);
            this.BacktohomeBtn.TabIndex = 53;
            this.BacktohomeBtn.Text = "Back to HomePage";
            this.BacktohomeBtn.UseVisualStyleBackColor = true;
            this.BacktohomeBtn.Click += new System.EventHandler(this.BacktohomeBtn_Click_1);
            // 
            // UpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.BacktohomeBtn);
            this.Controls.Add(this.ComboCategoryId);
            this.Controls.Add(this.ComboAuthorID);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.AvailableBox1);
            this.Controls.Add(this.updateEdition);
            this.Controls.Add(this.updateDescBox);
            this.Controls.Add(this.UpdateBookpubYr);
            this.Controls.Add(this.updateBookISBN);
            this.Controls.Add(this.updateBookTitle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Name = "UpdateBook";
            this.Text = "UpdateBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.ComboBox AvailableBox1;
        private System.Windows.Forms.TextBox updateEdition;
        private System.Windows.Forms.TextBox updateDescBox;
        private System.Windows.Forms.TextBox UpdateBookpubYr;
        private System.Windows.Forms.TextBox updateBookISBN;
        private System.Windows.Forms.TextBox updateBookTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ComboAuthorID;
        private System.Windows.Forms.ComboBox ComboCategoryId;
        private System.Windows.Forms.Button BacktohomeBtn;
    }
}