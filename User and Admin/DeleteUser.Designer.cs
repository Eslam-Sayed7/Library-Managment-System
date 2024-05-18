namespace Library_Managment_System.User_and_Admin
{
    partial class DeleteUser
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
            this.backtohome = new System.Windows.Forms.Button();
            this.button_deleteuserid = new System.Windows.Forms.Button();
            this.UserIdtxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LBLDeleteuser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backtohome
            // 
            this.backtohome.Location = new System.Drawing.Point(390, 70);
            this.backtohome.Name = "backtohome";
            this.backtohome.Size = new System.Drawing.Size(75, 37);
            this.backtohome.TabIndex = 17;
            this.backtohome.Text = "Back to HomePage";
            this.backtohome.UseVisualStyleBackColor = true;
            this.backtohome.Click += new System.EventHandler(this.backtohome_Click);
            // 
            // button_deleteuserid
            // 
            this.button_deleteuserid.Location = new System.Drawing.Point(309, 70);
            this.button_deleteuserid.Name = "button_deleteuserid";
            this.button_deleteuserid.Size = new System.Drawing.Size(75, 37);
            this.button_deleteuserid.TabIndex = 16;
            this.button_deleteuserid.Text = "Delete";
            this.button_deleteuserid.UseVisualStyleBackColor = true;
            this.button_deleteuserid.Click += new System.EventHandler(this.button_deleteuserid_Click);
            // 
            // UserIdtxtbox
            // 
            this.UserIdtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdtxtbox.Location = new System.Drawing.Point(172, 70);
            this.UserIdtxtbox.Name = "UserIdtxtbox";
            this.UserIdtxtbox.Size = new System.Drawing.Size(131, 35);
            this.UserIdtxtbox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter The userID";
            // 
            // LBLDeleteuser
            // 
            this.LBLDeleteuser.AutoSize = true;
            this.LBLDeleteuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDeleteuser.Location = new System.Drawing.Point(21, 35);
            this.LBLDeleteuser.Name = "LBLDeleteuser";
            this.LBLDeleteuser.Size = new System.Drawing.Size(108, 18);
            this.LBLDeleteuser.TabIndex = 13;
            this.LBLDeleteuser.Text = "Delete a user";
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 184);
            this.Controls.Add(this.backtohome);
            this.Controls.Add(this.button_deleteuserid);
            this.Controls.Add(this.UserIdtxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBLDeleteuser);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backtohome;
        private System.Windows.Forms.Button button_deleteuserid;
        private System.Windows.Forms.TextBox UserIdtxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBLDeleteuser;
    }
}