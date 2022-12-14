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
        private PageContext _pageContext;
        public Window2()
        {
            InitializeComponent();
            _pageContext = new PageContext();
            this.DataContext = _pageContext;
            _pageContext.AddPage(new mainPage());
        }

        private void MainPageClick(object sender, RoutedEventArgs e)
        {
            _pageContext.ChangeRootPage(new mainPage());
        }

        private void OrdersPageClick(object sender, RoutedEventArgs e)
        {
            _pageContext.ChangeRootPage(new OrdersPage());
        }
    }
}
