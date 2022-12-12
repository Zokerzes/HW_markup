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
using System.Windows.Shapes;

namespace HW_markup
{
    /// <summary>
    /// Логика взаимодействия для авторизации Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private AutorisationVM vm;
        public Window1()
        {
            InitializeComponent();
            vm = new AutorisationVM();
            this.DataContext = vm;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
            //MessageBox.Show($"{vm.LoginUser} {vm.PasswordUser}");
            vm.Auth(pwdBox.Password);

        }
    }
}
