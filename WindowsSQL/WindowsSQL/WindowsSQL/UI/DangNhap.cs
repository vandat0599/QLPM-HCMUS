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
    public partial class FormDang_nhap : Form
    {
        public FormDang_nhap()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void btnDang_nhap_Click(object sender, EventArgs e)
        {
            UserDAO _DAO = new UserDAO();
            DataTable dt = _DAO.kiemTraChuPhongMach(textUsername.Text, textPassword.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Ban khong co quyen truy cap!");
            }
            else
            {
                bool La_chu=dt.Rows[0].Field<bool>(0);
                if (La_chu)
                {
                    MessageBox.Show("Dang nhap thanh cong!");
                    Form_Quan_Ly fql = new Form_Quan_Ly();
                    this.Hide();
                    fql.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Dang nhap thanh cong!");
                    Form_Bac_Si fbs = new Form_Bac_Si();
                    fbs.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
