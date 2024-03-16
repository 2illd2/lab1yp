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
using YP.YP1DataSetTableAdapters;
namespace YP
{
    public partial class ProductsWindow : Window
    {
        private ProductsTableAdapter products = new ProductsTableAdapter();
        public ProductsWindow()
        {
            InitializeComponent(); ProductsDataGrid.ItemsSource = products.GetData();
        }
    }
}
