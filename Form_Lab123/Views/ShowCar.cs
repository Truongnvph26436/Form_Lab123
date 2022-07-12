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
    public partial class ShowCar : Form
    {
        public ShowCar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCar newCar = new AddCar();
            newCar.ShowDialog();
        }

        private void cb_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hienthi.Checked)
            {
                FileController fileC = new FileController();
                string path =
                    @"C:\Users\ADMIN\OneDrive\Desktop\C#\C#3\lab_ass\Form_Lab123\Form_Lab123\Views\XMLFile1.xml";
                var lstcar = fileC.ReadCarfromXML<NewCar>(path);
                if (lstcar == null)
                {
                    MessageBox.Show("Không có dữ liệu để hiện thị vui lòng thêm xe");
                }
                else
                {
                    dgv_showCart.DataSource = lstcar;
                    dgv_showCart.Columns[0].HeaderText = "Tên xe";
                    dgv_showCart.Columns[1].HeaderText = "Hãng xe";
                    dgv_showCart.Columns[2].HeaderText = "Giá cả";
                    dgv_showCart.Columns[3].HeaderText = "Số lượng";
                }
            }
            else
            {
                dgv_showCart.DataSource = null;
            }
        }
    }
}