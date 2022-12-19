using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_markup.Model
{
    public class OrderProduct  //храним количество товара из заказа 
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
