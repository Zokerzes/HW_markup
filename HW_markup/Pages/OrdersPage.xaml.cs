using HW_markup.Model;
using HW_markup.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : UserControl
    {
        private OrdersVM _vm;

        public OrdersPage()
        {
            InitializeComponent();
            _vm=new OrdersVM();
            this.DataContext = _vm;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            _vm.UpdateListOrders(); // метод: поиск по имени ид дате продукту
        }

        private void DeleteOrders_Click(object sender, RoutedEventArgs e)
        {
            _vm.SelectedOrders = OrdersLV.SelectedItems.Cast<Order>().ToList(); // ListView x:Name="OrdersLV"
            _vm.DeleteOrders();
        }
    }
}
