namespace DatabaseTutorial
{
    partial class CommandBuilder
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
            this.dgv_UserData = new System.Windows.Forms.DataGridView();
            this.btn_operate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_UserData
            // 
            this.dgv_UserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserData.Location = new System.Drawing.Point(12, 12);
            this.dgv_UserData.Name = "dgv_UserData";
            this.dgv_UserData.Size = new System.Drawing.Size(610, 306);
            this.dgv_UserData.TabIndex = 0;
            // 
            // btn_operate
            // 
            this.btn_operate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_operate.Location = new System.Drawing.Point(12, 324);
            this.btn_operate.Name = "btn_operate";
            this.btn_operate.Size = new System.Drawing.Size(610, 37);
            this.btn_operate.TabIndex = 1;
            this.btn_operate.Text = "Perform Operation";
            this.btn_operate.UseVisualStyleBackColor = true;
            this.btn_operate.Click += new System.EventHandler(this.btn_operate_Click);
            // 
            // CommandBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_operate);
            this.Controls.Add(this.dgv_UserData);
            this.Name = "CommandBuilder";
            this.Text = "CommandBuilder";
            this.Load += new System.EventHandler(this.CommandBuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_UserData;
        private System.Windows.Forms.Button btn_operate;
    }
}