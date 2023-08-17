namespace DatabaseTutorial
{
    partial class Home
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
            this.cbo_CountryHome = new System.Windows.Forms.ComboBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PasswordHome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_EmailHome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NameHome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbo_CountryHome
            // 
            this.cbo_CountryHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_CountryHome.FormattingEnabled = true;
            this.cbo_CountryHome.Items.AddRange(new object[] {
            "Germany",
            "France",
            "USA",
            "United Kingdom",
            "India",
            "Australia",
            "Japan"});
            this.cbo_CountryHome.Location = new System.Drawing.Point(149, 299);
            this.cbo_CountryHome.Name = "cbo_CountryHome";
            this.cbo_CountryHome.Size = new System.Drawing.Size(189, 32);
            this.cbo_CountryHome.TabIndex = 20;
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(22, 352);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(316, 32);
            this.btn_Update.TabIndex = 19;
            this.btn_Update.Text = "Update User Informations";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Country: ";
            // 
            // txt_PasswordHome
            // 
            this.txt_PasswordHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PasswordHome.Location = new System.Drawing.Point(149, 256);
            this.txt_PasswordHome.Name = "txt_PasswordHome";
            this.txt_PasswordHome.Size = new System.Drawing.Size(189, 29);
            this.txt_PasswordHome.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password:";
            // 
            // txt_EmailHome
            // 
            this.txt_EmailHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmailHome.Location = new System.Drawing.Point(149, 216);
            this.txt_EmailHome.Name = "txt_EmailHome";
            this.txt_EmailHome.Size = new System.Drawing.Size(189, 29);
            this.txt_EmailHome.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email:";
            // 
            // txt_NameHome
            // 
            this.txt_NameHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameHome.Location = new System.Drawing.Point(149, 176);
            this.txt_NameHome.Name = "txt_NameHome";
            this.txt_NameHome.Size = new System.Drawing.Size(189, 29);
            this.txt_NameHome.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Change User Settings";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(372, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 155);
            this.button1.TabIndex = 21;
            this.button1.Text = "Delete User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Welcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Welcome.Location = new System.Drawing.Point(230, 27);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(241, 31);
            this.lbl_Welcome.TabIndex = 22;
            this.lbl_Welcome.Text = "Welcome username";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbo_CountryHome);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_PasswordHome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_EmailHome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NameHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_CountryHome;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_PasswordHome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_EmailHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NameHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Welcome;
    }
}