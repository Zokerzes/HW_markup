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
            Orders = UsersDB.Context.Orders.ToList();
        }
        public List<Order> Orders { get; set; }

        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set 
            {
                
                _searchText = value;
                Orders = UsersDB.Context.Orders.
                    Where(x =>(int.TryParse(_searchText, out int id) && x.Id==id) 
                                        || _searchText == string.Empty).
                    ToList();
                OnPropertyChanged(); 
            }
        }
    }
}
