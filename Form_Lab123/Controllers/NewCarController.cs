using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Form_Lab123.Models;

namespace Form_Lab123.Controllers
{
    internal class NewCarController
    {
        public NewCar AddNewCar(string ten, string hang, string gia, string soLuong)
        {
            return new NewCar(ten, hang, gia, soLuong);
        }
    }
}