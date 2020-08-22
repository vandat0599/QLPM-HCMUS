using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsSQL.BUS;
using WindowsSQL.DTO;

namespace WindowsSQL
{
    public partial class Form_Quan_Ly : Form
    {
        public Form_Quan_Ly()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BenhNhanBUS bus = new BenhNhanBUS();
            if (bus.create(new BenhNhanDTO(
                id: 0,
                hoTen: "Vo van dat 2",
                gioiTinh: "Nam 2",
                namSinh: 1999,
                diaChi: "Quan Phu Nhuan 2"
                )))
            {
                MessageBox.Show("Them thanh cong");
            }
            else
            {
                MessageBox.Show("Them That bai");
            }
        }
    }
}
