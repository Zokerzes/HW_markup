using HW_markup.Pages;
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
using System.Windows.Shapes;

namespace HW_markup
{
    /// <summary>
    /// Логика взаимодействия для Window2 UserWindow.xaml
    /// </summary>
    public partial class Window2 : Window
    {
       
        public Window2()
        {
            InitializeComponent();
           
            this.DataContext = PageContext.CurrentPageContext;
            PageContext.CurrentPageContext.AddPage(new mainPage());
        }

        private void MainPageClick(object sender, RoutedEventArgs e)
        {
            PageContext.CurrentPageContext.ChangeRootPage(new mainPage());
        }

        private void OrdersPageClick(object sender, RoutedEventArgs e)
        {
            PageContext.CurrentPageContext.ChangeRootPage(new OrdersPage());
        }
    }
}
