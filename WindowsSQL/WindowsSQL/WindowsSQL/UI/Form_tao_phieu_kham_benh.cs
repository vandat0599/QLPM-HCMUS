using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
namespace WindowsSQL
{
    public partial class Form_tao_phieu_kham_benh : Form
    {
        public Form_tao_phieu_kham_benh()
        {
            InitializeComponent();
        }

        private void Form_tao_phieu_kham_benh_Load(object sender, EventArgs e)
        {
            PhieuKhamBenhDAO _DAO = new PhieuKhamBenhDAO();
            //dgv = _DAO.Danh_sach_don_thuoc();

        }
    }
}
