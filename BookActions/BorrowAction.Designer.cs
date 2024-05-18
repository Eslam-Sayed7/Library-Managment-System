namespace Library_Managment_System.BookActions
{
    partial class BorrowAction
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookIdToBorrow = new System.Windows.Forms.TextBox();
            this.UserIdToBorrow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.RtrnHomePage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "BookId";
            // 
            // bookIdToBorrow
            // 
            this.bookIdToBorrow.Location = new System.Drawing.Point(152, 74);
            this.bookIdToBorrow.Name = "bookIdToBorrow";
            this.bookIdToBorrow.Size = new System.Drawing.Size(100, 20);
            this.bookIdToBorrow.TabIndex = 1;
            // 
            // UserIdToBorrow
            // 
            this.UserIdToBorrow.Location = new System.Drawing.Point(152, 119);
            this.UserIdToBorrow.Name = "UserIdToBorrow";
            this.UserIdToBorrow.Size = new System.Drawing.Size(100, 20);
            this.UserIdToBorrow.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserID";
            // 
            // borrowBtn
            // 
            this.borrowBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.borrowBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.borrowBtn.Location = new System.Drawing.Point(362, 60);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(152, 35);
            this.borrowBtn.TabIndex = 22;
            this.borrowBtn.Text = "Borrow";
            this.borrowBtn.UseVisualStyleBackColor = false;
            this.borrowBtn.Click += new System.EventHandler(this.borrowBtn_Click);
            // 
            // RtrnHomePage
            // 
            this.RtrnHomePage.BackColor = System.Drawing.Color.LightSalmon;
            this.RtrnHomePage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RtrnHomePage.Location = new System.Drawing.Point(362, 101);
            this.RtrnHomePage.Name = "RtrnHomePage";
            this.RtrnHomePage.Size = new System.Drawing.Size(152, 35);
            this.RtrnHomePage.TabIndex = 23;
            this.RtrnHomePage.Text = "Return to home page";
            this.RtrnHomePage.UseVisualStyleBackColor = false;
            this.RtrnHomePage.Click += new System.EventHandler(this.RtrnHomePage_Click);
            // 
            // BorrowAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 243);
            this.Controls.Add(this.RtrnHomePage);
            this.Controls.Add(this.borrowBtn);
            this.Controls.Add(this.UserIdToBorrow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookIdToBorrow);
            this.Controls.Add(this.label1);
            this.Name = "BorrowAction";
            this.Text = "Borrow Action";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookIdToBorrow;
        private System.Windows.Forms.TextBox UserIdToBorrow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button borrowBtn;
        private System.Windows.Forms.Button RtrnHomePage;
    }
}