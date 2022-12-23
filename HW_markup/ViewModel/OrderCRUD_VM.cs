using HW_markup.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_markup.ViewModel
{
    internal class OrderCRUD_VM : NotifyClass
    {
        public OrderCRUD_VM(Order order = null)
        {
            _currentOrder = new Order();
            if (order != null)              
            {
                _currentOrder.Products = order.Products;
                _currentOrder.Client = order.Client;
                _currentOrder.Date = order.Date;
                _currentOrder.Id = order.Id;
            }
        }

        

        private Order _currentOrder;
        public Order CurrentOrder
        {
            get => _currentOrder;
            private set => _currentOrder = value; //из вне запрещено редактировать
        }
        public int Id
        {
            get
            {
                return _currentOrder.Id;
            }
            set
            {
                _currentOrder.Id = value;
                OnPropertyChanged();
            }
        }

        public string Client
        {
            get
            {
                return _currentOrder.Client;
            }
            set
            {
                _currentOrder.Client = value;
                OnPropertyChanged();
            }
        }

        public DateTime Data
        {
            get
            {
                return _currentOrder.Date;
            }
            set
            {
                _currentOrder.Date = value;
                OnPropertyChanged();
            }
        }

        public decimal Price
        {
            get
            {
                return _currentOrder.Price;
            }
        }

        public ObservableCollection<OrderProduct> Products
        {
            get
            {
                return _currentOrder.Products;
            }
            set
            {
                _currentOrder.Products = value;
                OnPropertyChanged(nameof(Price));
            }
        }
        private OrderProduct _selectProduct;   //выделеный продукт
        public OrderProduct SelectProduct
        {
            get => _selectProduct;
            set
            {
                _selectProduct = value;
                OnPropertyChanged();
            }
        }
        public void AddProduct()  //добавление нового продукта
        {
            
        }

        public void DelProduct() //удаление прдукта
        {
            Products.Remove(SelectProduct);
            OnPropertyChanged("Price");
        }

    }
}
