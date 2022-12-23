using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_markup.Model
{
    public class OrderProduct : NotifyClass //храним количество товара из заказа 
    {
        public Product Product { get; set; }
        private int _quantity;
        public int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged();
                OnPropertyChanged("Price");
            }
        } 
        public decimal Price => Product.Price * Quantity;
    }
}
