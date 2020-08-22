namespace WindowsSQL
{
    partial class Form_them_benh_nhan
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textTen_benh_nhan = new System.Windows.Forms.TextBox();
            this.textGioi_tinh = new System.Windows.Forms.TextBox();
            this.textNam_sinh = new System.Windows.Forms.TextBox();
            this.textDia_chi = new System.Windows.Forms.TextBox();
            this.btnThem_benh_nhan_confirm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên bệnh nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // textTen_benh_nhan
            // 
            this.textTen_benh_nhan.Location = new System.Drawing.Point(33, 43);
            this.textTen_benh_nhan.Name = "textTen_benh_nhan";
            this.textTen_benh_nhan.Size = new System.Drawing.Size(100, 20);
            this.textTen_benh_nhan.TabIndex = 4;
            // 
            // textGioi_tinh
            // 
            this.textGioi_tinh.Location = new System.Drawing.Point(179, 43);
            this.textGioi_tinh.Name = "textGioi_tinh";
            this.textGioi_tinh.Size = new System.Drawing.Size(100, 20);
            this.textGioi_tinh.TabIndex = 5;
            // 
            // textNam_sinh
            // 
            this.textNam_sinh.Location = new System.Drawing.Point(306, 43);
            this.textNam_sinh.Name = "textNam_sinh";
            this.textNam_sinh.Size = new System.Drawing.Size(100, 20);
            this.textNam_sinh.TabIndex = 6;
            // 
            // textDia_chi
            // 
            this.textDia_chi.Location = new System.Drawing.Point(442, 43);
            this.textDia_chi.Name = "textDia_chi";
            this.textDia_chi.Size = new System.Drawing.Size(100, 20);
            this.textDia_chi.TabIndex = 7;
            // 
            // btnThem_benh_nhan_confirm
            // 
            this.btnThem_benh_nhan_confirm.Location = new System.Drawing.Point(233, 69);
            this.btnThem_benh_nhan_confirm.Name = "btnThem_benh_nhan_confirm";
            this.btnThem_benh_nhan_confirm.Size = new System.Drawing.Size(113, 23);
            this.btnThem_benh_nhan_confirm.TabIndex = 8;
            this.btnThem_benh_nhan_confirm.Text = "Thêm";
            this.btnThem_benh_nhan_confirm.UseVisualStyleBackColor = true;
            this.btnThem_benh_nhan_confirm.Click += new System.EventHandler(this.btnThem_benh_nhan_confirm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 290);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form_them_benh_nhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 412);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThem_benh_nhan_confirm);
            this.Controls.Add(this.textDia_chi);
            this.Controls.Add(this.textNam_sinh);
            this.Controls.Add(this.textGioi_tinh);
            this.Controls.Add(this.textTen_benh_nhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_them_benh_nhan";
            this.Text = "Danh sách khám bệnh";
            this.Load += new System.EventHandler(this.Form_them_benh_nhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTen_benh_nhan;
        private System.Windows.Forms.TextBox textGioi_tinh;
        private System.Windows.Forms.TextBox textNam_sinh;
        private System.Windows.Forms.TextBox textDia_chi;
        private System.Windows.Forms.Button btnThem_benh_nhan_confirm;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}