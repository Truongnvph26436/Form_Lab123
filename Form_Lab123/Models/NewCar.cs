using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Lab123.Models
{
    public class NewCar
    {
        public string tenXe { get; set; }
        public string hangSX { get; set; }
        public string giaCa { get; set; }
        public string soLuong { get; set; }

        public NewCar()
        {
        }

        public NewCar(string tenXe, string hangSx, string giaCa, string soLuong)
        {
            this.tenXe = tenXe;
            hangSX = hangSx;
            this.giaCa = giaCa;
            this.soLuong = soLuong;
        }
    }
}