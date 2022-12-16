using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_markup.Model
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public string Client { get; set; }
        public ObservableCollection<OrderProduct> Products { get; set; } //вместо листа _ для впф _ для уведомлений впф
        public decimal Price
        {
            get 
            { 
                return Products.Sum(x => x.Product.Price * x.Quantity); 
            }
        }
    }
}
