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
            Orders = UsersDB.Context.Orders;
        }
        public ObservableCollection<Order> Orders { get; set; }
    }
}
