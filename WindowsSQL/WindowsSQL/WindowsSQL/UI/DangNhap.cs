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
using WindowsSQL.BUS;
using WindowsSQL.DTO;

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
            UserBUS userBUS = new UserBUS();
            UserDTO user = userBUS.getUserByUserName(textUsername.Text, textPassword.Text);
            if (user == null)
            {
                MessageBox.Show("Ban khong co quyen truy cap!");
            }
            else
            {
                MessageBox.Show("Dang nhap thanh cong!");
                if (user.IsChuPhongMach)
                {
                    
                    Form_Quan_Ly form = new Form_Quan_Ly();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    Form_Bac_Si form = new Form_Bac_Si();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
                
            }
        }
    }
}
