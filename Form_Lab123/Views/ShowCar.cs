using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form_Lab123.Models;

namespace Form_Lab123.Views
{
    public partial class ShowCar : Form
    {
        private List<NewCar> _lstNewCars;

        public ShowCar()
        {
            InitializeComponent();
        }

        public ShowCar(List<NewCar> showList)
        {
            InitializeComponent();
            _lstNewCars = showList;
        }

        private void ShowCar_Load(object sender, EventArgs e)
        {
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
                dgv_showCart.DataSource = _lstNewCars;
                dgv_showCart.Columns[0].HeaderText = "Tên xe";
                dgv_showCart.Columns[1].HeaderText = "Hãng xe";
                dgv_showCart.Columns[2].HeaderText = "Giá cả";
                dgv_showCart.Columns[3].HeaderText = "Số lượng";
            }
            else
            {
                dgv_showCart.DataSource = null;
            }
        }
    }
}