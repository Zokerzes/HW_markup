using HW_markup.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_markup.ViewModel
{
    internal class OrdersVM : NotifyClass
    {
        public OrdersVM()
        {
            _searchText = "";
            Orders = UsersDB.Context.Orders.ToList();
        }
        public List<Order> Orders { get; set; }
        public List<Order> SelectedOrders { get; set; }

        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set 
            {
                
                _searchText = value;
                Orders = UsersDB.Context.Orders.
                    Where(x =>(int.TryParse(_searchText, out int id) && x.Id==id) 
                                        || _searchText == string.Empty).ToList();
                OnPropertyChanged(); 
            }
        }
        public void UpdateListOrders()
        {
            Orders = UsersDB.Context.Orders.      
                   Where(x => _searchText == string.Empty 
                              || (int.TryParse(_searchText, out int id) && x.Id == id)
                              || x.Client.ToLower().Contains(_searchText.ToLower())
                              || (DateTime.TryParse(_searchText, out DateTime date) && date == x.Date)
                              || (x.Products.FirstOrDefault(y=>y.Product.Name.ToLower().Contains(_searchText.ToLower()))!=null)).
                   ToList();  // поиск по имени ид дате продукту
            OnPropertyChanged("Orders");
        }
        
        public void DeleteOrders()
        {
            foreach (var item in SelectedOrders)
            {
                UsersDB.Context.Orders.Remove(item);    //проходим по списку и удаляем те которые выделены
            }
            Orders = UsersDB.Context.Orders.ToList();   // обновляем ордерз
            SelectedOrders.Clear();                     //чистим записи
            OnPropertyChanged("Orders");                //команда на обновление
        }
    }
}
