using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form_Lab123.Controllers;
using Form_Lab123.Models;
using Microsoft.VisualBasic;

namespace Form_Lab123.Views
{
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
            lb_loiten.Visible = false;
            lb_loihang.Visible = false;
            lb_loigia.Visible = false;
            lb_loisluong.Visible = false;
            lb_checkgia.Visible = false;
            lb_checksoluong.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region checkTextBox

            int a = 0;
            if (tb_tenXe.Text == "")
            {
                lb_loiten.Visible = true;
            }
            else
            {
                lb_loiten.Visible = false;
                a = a + 1;
            }

            if (cbp_hangXe.Text == "")
            {
                lb_loihang.Visible = true;
            }
            else
            {
                lb_loihang.Visible = false;
                a = a + 1;
            }

            if (tb_gia.Text == "")
            {
                lb_loigia.Visible = true;
            }
            else if (tb_gia.Text != "" && checkSo(tb_gia.Text))
            {
                lb_loigia.Visible = false;
                a = a + 1;
            }

            if (tb_soLuong.Text == "")
            {
                lb_loisluong.Visible = true;
            }
            else if (tb_soLuong.Text != "" && checkSo(tb_soLuong.Text))
            {
                lb_loisluong.Visible = false;
                a = a + 1;
            }

            #endregion

            if (a >= 4)
            {
                #region AddCar

                NewCarController newC = new NewCarController();
                FileController fileC = new FileController();
                NewCar car = newC.AddNewCar(tb_tenXe.Text, cbp_hangXe.Text, tb_gia.Text, tb_soLuong.Text);
                string path =
                    @"C:\Users\ADMIN\OneDrive\Desktop\C#\C#3\lab_ass\Form_Lab123\Form_Lab123\Views\XMLFile1.xml";
                fileC.SaveCarfromXML<NewCar>(path, car);
                MessageBox.Show("Thêm xe thành công");
                this.Close();

                #endregion
            }
        }

        private void cbp_hangXe_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        bool checkSo(string value)
        {
            var check = Regex.IsMatch(value, "^[0-9]+$");
            return check;
        }

        private void tb_gia_TextChanged(object sender, EventArgs e)
        {
            var a = checkSo(tb_gia.Text);
            if (!a)
            {
                lb_loigia.Visible = false;
                lb_checkgia.Visible = true;
            }
            else
            {
                lb_checkgia.Visible = false;
            }
        }

        private void tb_soLuong_TextChanged(object sender, EventArgs e)
        {
            var a = checkSo(tb_soLuong.Text);
            if (!a)
            {
                lb_loisluong.Visible = false;
                lb_checksoluong.Visible = true;
            }
            else
            {
                lb_checksoluong.Visible = false;
            }
        }
    }
}