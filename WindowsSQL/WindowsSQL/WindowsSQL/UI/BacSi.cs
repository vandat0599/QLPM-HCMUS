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
    public partial class Form_Bac_Si : Form
    {
        public Form_Bac_Si()
        {
            InitializeComponent();
        }

        private void Form_Bac_Si_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_benh_nhan_Click(object sender, EventArgs e)
        {
            Form_them_benh_nhan form = new Form_them_benh_nhan();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_tao_phieu_kham_benh form = new Form_tao_phieu_kham_benh();
            form.ShowDialog();
        }
    }
}
