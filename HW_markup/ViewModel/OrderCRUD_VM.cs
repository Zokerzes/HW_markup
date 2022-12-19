using HW_markup.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_markup.ViewModel
{
    internal class OrderCRUD_VM:NotifyClass
    {
        public OrderCRUD_VM(Order order = null)
        {
            if(order == null)               // если заказ нул то создаем новый заказ
            {
                _currentOrder = new Order();
            }
            else { _currentOrder = order; } // иначе старое значение
        }
        private Order _currentOrder;
        public Order CurrentOrder 
        {
            get => _currentOrder;
            private set => _currentOrder = value; //из вне запрещено редактировать
        }

    }
}
