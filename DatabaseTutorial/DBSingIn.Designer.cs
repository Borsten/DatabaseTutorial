namespace DatabaseTutorial
{
    partial class DBSingIn
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
            this.btn_DBSignIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DBAccess = new System.Windows.Forms.TextBox();
            this.txt_Catalog = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_DBSignIn
            // 
            this.btn_DBSignIn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_DBSignIn.Location = new System.Drawing.Point(193, 229);
            this.btn_DBSignIn.Name = "btn_DBSignIn";
            this.btn_DBSignIn.Size = new System.Drawing.Size(106, 33);
            this.btn_DBSignIn.TabIndex = 0;
            this.btn_DBSignIn.Text = "Sign In";
            this.btn_DBSignIn.UseVisualStyleBackColor = true;
            this.btn_DBSignIn.Click += new System.EventHandler(this.btn_DBSignIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Database:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(11, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // txt_DBAccess
            // 
            this.txt_DBAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_DBAccess.Location = new System.Drawing.Point(150, 67);
            this.txt_DBAccess.Name = "txt_DBAccess";
            this.txt_DBAccess.Size = new System.Drawing.Size(444, 29);
            this.txt_DBAccess.TabIndex = 4;
            // 
            // txt_Catalog
            // 
            this.txt_Catalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_Catalog.Location = new System.Drawing.Point(150, 107);
            this.txt_Catalog.Name = "txt_Catalog";
            this.txt_Catalog.Size = new System.Drawing.Size(444, 29);
            this.txt_Catalog.TabIndex = 5;
            // 
            // txt_User
            // 
            this.txt_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_User.Location = new System.Drawing.Point(150, 147);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(444, 29);
            this.txt_User.TabIndex = 6;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_Password.Location = new System.Drawing.Point(150, 187);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(444, 29);
            this.txt_Password.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(11, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Catalog:";
            // 
            // DBSingIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 299);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.txt_Catalog);
            this.Controls.Add(this.txt_DBAccess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DBSignIn);
            this.Name = "DBSingIn";
            this.Text = "DBSingIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DBSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_DBAccess;
        private System.Windows.Forms.TextBox txt_Catalog;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label4;
    }
}