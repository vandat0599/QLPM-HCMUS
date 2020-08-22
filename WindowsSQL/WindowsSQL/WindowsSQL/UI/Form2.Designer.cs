namespace WindowsSQL
{
    partial class FormDang_nhap
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
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDang_nhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(244, 110);
            this.textUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(197, 22);
            this.textUsername.TabIndex = 0;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(244, 151);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(197, 22);
            this.textPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập username và password";
            // 
            // btnDang_nhap
            // 
            this.btnDang_nhap.Location = new System.Drawing.Point(341, 196);
            this.btnDang_nhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDang_nhap.Name = "btnDang_nhap";
            this.btnDang_nhap.Size = new System.Drawing.Size(100, 28);
            this.btnDang_nhap.TabIndex = 3;
            this.btnDang_nhap.Text = "Đăng nhập";
            this.btnDang_nhap.UseVisualStyleBackColor = true;
            this.btnDang_nhap.Click += new System.EventHandler(this.btnDang_nhap_Click);
            // 
            // FormDang_nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 339);
            this.Controls.Add(this.btnDang_nhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDang_nhap";
            this.Text = "Dang_nhap";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDang_nhap;
    }
}