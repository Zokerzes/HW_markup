using HW_markup.Model;
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
    /// Логика взаимодействия для SelectProductWindow.xaml
    /// </summary>
    public partial class SelectProductWindow : Window
    {
        public SelectProductWindow()
        {
           InitializeComponent();
            _nodes = new List<INode>(UsersDB.Context.Folders);
            ProductsTree.ItemsSource = _nodes; 
        }

        private List<INode> _nodes;

        private Product _selectProduct;
        public Product SelectProduct { get { return _selectProduct; } }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            ProductNode product= ProductsTree.SelectedItem as ProductNode;
            if(product != null) 
            {
                _selectProduct = product.Product;
            }
            
            this.Close();
        }
    }
}
