using HW_markup.Model;
using HW_markup.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW_markup.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrderCRUD.xaml
    /// </summary>
    public partial class OrderCRUD : Page
    {
        private OrderCRUD_VM _vm;
        public OrderCRUD(Order order=null)
        {
            InitializeComponent();
            _vm= new OrderCRUD_VM(order);
            this.DataContext = _vm;
        }


       
    }
}
