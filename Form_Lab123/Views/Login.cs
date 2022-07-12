using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form_Lab123.Controllers;
using Form_Lab123.Models;

namespace Form_Lab123.Views
{
    public partial class Login : Form
    {
        private List<Taikhoan> _lstTaikhoans;

        public Login()
        {
            InitializeComponent();
            lb_loitk.Visible = false;
            lb_loimk.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (tb_password.Text == "")
            {
                lb_loitk.Visible = true;
            }
            else
            {
                lb_loitk.Visible = false;
                a = a + 1;
            }

            if (tb_username.Text == "")
            {
                lb_loimk.Visible = true;
            }
            else
            {
                lb_loimk.Visible = false;
                a = a + 1;
            }

            if (a >= 2)
            {
                var checkAdmin =
                    _lstTaikhoans.FirstOrDefault(c => c.UserName == tb_username.Text && c.Password == tb_password.Text);
                if (checkAdmin == null)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công");
                    FileController fileC = new FileController();
                    string path =
                        @"C:\Users\ADMIN\OneDrive\Desktop\C#\C#3\lab_ass\Form_Lab123\Form_Lab123\Views\XMLFile1.xml";
                    List<NewCar> lstcar = fileC.ReadCarfromXML<NewCar>(path);
                    ShowCar showCar = new ShowCar(lstcar);
                    showCar.ShowDialog();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            _lstTaikhoans = new List<Taikhoan>()
            {
                new Taikhoan("Admin01", "1234"),
                new Taikhoan("Admin02", "1234"),
                new Taikhoan("Admin03", "1234")
            };
        }
    }
}