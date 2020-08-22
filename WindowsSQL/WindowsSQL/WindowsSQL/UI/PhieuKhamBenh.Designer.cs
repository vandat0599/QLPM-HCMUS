namespace WindowsSQL
{
    partial class Form_tao_phieu_kham_benh
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
            this.labelHo_ten = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateNgay_kham = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textTrieu_chung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDu_doan_loai_benh = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.textAdd_thuoc = new System.Windows.Forms.TextBox();
            this.textAdd_don_vi = new System.Windows.Forms.TextBox();
            this.textSo_luong = new System.Windows.Forms.TextBox();
            this.textCach_dung = new System.Windows.Forms.TextBox();
            this.btnThem_don_thuoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // labelHo_ten
            // 
            this.labelHo_ten.AutoSize = true;
            this.labelHo_ten.Location = new System.Drawing.Point(115, 26);
            this.labelHo_ten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHo_ten.Name = "labelHo_ten";
            this.labelHo_ten.Size = new System.Drawing.Size(0, 17);
            this.labelHo_ten.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày khám:";
            // 
            // dateNgay_kham
            // 
            this.dateNgay_kham.Location = new System.Drawing.Point(416, 17);
            this.dateNgay_kham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateNgay_kham.Name = "dateNgay_kham";
            this.dateNgay_kham.Size = new System.Drawing.Size(265, 22);
            this.dateNgay_kham.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Triệu chứng:";
            // 
            // textTrieu_chung
            // 
            this.textTrieu_chung.Location = new System.Drawing.Point(152, 58);
            this.textTrieu_chung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textTrieu_chung.Name = "textTrieu_chung";
            this.textTrieu_chung.Size = new System.Drawing.Size(132, 22);
            this.textTrieu_chung.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dự đoán loại bệnh:";
            // 
            // textDu_doan_loai_benh
            // 
            this.textDu_doan_loai_benh.Location = new System.Drawing.Point(461, 52);
            this.textDu_doan_loai_benh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textDu_doan_loai_benh.Name = "textDu_doan_loai_benh";
            this.textDu_doan_loai_benh.Size = new System.Drawing.Size(132, 22);
            this.textDu_doan_loai_benh.TabIndex = 7;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(53, 96);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(629, 389);
            this.dgv.TabIndex = 8;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // textAdd_thuoc
            // 
            this.textAdd_thuoc.Location = new System.Drawing.Point(125, 492);
            this.textAdd_thuoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textAdd_thuoc.Name = "textAdd_thuoc";
            this.textAdd_thuoc.Size = new System.Drawing.Size(132, 22);
            this.textAdd_thuoc.TabIndex = 9;
            // 
            // textAdd_don_vi
            // 
            this.textAdd_don_vi.Location = new System.Drawing.Point(267, 492);
            this.textAdd_don_vi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textAdd_don_vi.Name = "textAdd_don_vi";
            this.textAdd_don_vi.Size = new System.Drawing.Size(132, 22);
            this.textAdd_don_vi.TabIndex = 10;
            // 
            // textSo_luong
            // 
            this.textSo_luong.Location = new System.Drawing.Point(408, 492);
            this.textSo_luong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSo_luong.Name = "textSo_luong";
            this.textSo_luong.Size = new System.Drawing.Size(132, 22);
            this.textSo_luong.TabIndex = 11;
            // 
            // textCach_dung
            // 
            this.textCach_dung.Location = new System.Drawing.Point(549, 492);
            this.textCach_dung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCach_dung.Name = "textCach_dung";
            this.textCach_dung.Size = new System.Drawing.Size(132, 22);
            this.textCach_dung.TabIndex = 12;
            // 
            // btnThem_don_thuoc
            // 
            this.btnThem_don_thuoc.Location = new System.Drawing.Point(289, 554);
            this.btnThem_don_thuoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem_don_thuoc.Name = "btnThem_don_thuoc";
            this.btnThem_don_thuoc.Size = new System.Drawing.Size(137, 28);
            this.btnThem_don_thuoc.TabIndex = 13;
            this.btnThem_don_thuoc.Text = "Thêm đơn thuốc";
            this.btnThem_don_thuoc.UseVisualStyleBackColor = true;
            // 
            // Form_tao_phieu_kham_benh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 604);
            this.Controls.Add(this.btnThem_don_thuoc);
            this.Controls.Add(this.textCach_dung);
            this.Controls.Add(this.textSo_luong);
            this.Controls.Add(this.textAdd_don_vi);
            this.Controls.Add(this.textAdd_thuoc);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.textDu_doan_loai_benh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textTrieu_chung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateNgay_kham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelHo_ten);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_tao_phieu_kham_benh";
            this.Text = "Phiếu khám bệnh";
            this.Load += new System.EventHandler(this.Form_tao_phieu_kham_benh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHo_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateNgay_kham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTrieu_chung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDu_doan_loai_benh;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox textAdd_thuoc;
        private System.Windows.Forms.TextBox textAdd_don_vi;
        private System.Windows.Forms.TextBox textSo_luong;
        private System.Windows.Forms.TextBox textCach_dung;
        private System.Windows.Forms.Button btnThem_don_thuoc;
    }
}