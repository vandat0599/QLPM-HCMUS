namespace WindowsSQL
{
    partial class Form_Bac_Si
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
            this.btnThem_benh_nhan = new System.Windows.Forms.Button();
            this.btnTao_phieu_kham_benh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThem_benh_nhan
            // 
            this.btnThem_benh_nhan.Location = new System.Drawing.Point(100, 13);
            this.btnThem_benh_nhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem_benh_nhan.Name = "btnThem_benh_nhan";
            this.btnThem_benh_nhan.Size = new System.Drawing.Size(169, 28);
            this.btnThem_benh_nhan.TabIndex = 0;
            this.btnThem_benh_nhan.Text = "Danh sách khám bệnh";
            this.btnThem_benh_nhan.UseVisualStyleBackColor = true;
            this.btnThem_benh_nhan.Click += new System.EventHandler(this.btnThem_benh_nhan_Click);
            // 
            // btnTao_phieu_kham_benh
            // 
            this.btnTao_phieu_kham_benh.Location = new System.Drawing.Point(100, 69);
            this.btnTao_phieu_kham_benh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTao_phieu_kham_benh.Name = "btnTao_phieu_kham_benh";
            this.btnTao_phieu_kham_benh.Size = new System.Drawing.Size(169, 28);
            this.btnTao_phieu_kham_benh.TabIndex = 1;
            this.btnTao_phieu_kham_benh.Text = "Tạo phiếu khám bệnh";
            this.btnTao_phieu_kham_benh.UseVisualStyleBackColor = true;
            this.btnTao_phieu_kham_benh.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Bac_Si
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 395);
            this.Controls.Add(this.btnTao_phieu_kham_benh);
            this.Controls.Add(this.btnThem_benh_nhan);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Bac_Si";
            this.Text = "Form_Bac_Si";
            this.Load += new System.EventHandler(this.Form_Bac_Si_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThem_benh_nhan;
        private System.Windows.Forms.Button btnTao_phieu_kham_benh;
    }
}