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
namespace YP12
{
    public partial class ProductsWindow : Window
    {
        private YP1Entities context = new YP1Entities(); public ProductsWindow()
        {
            InitializeComponent();
            ProductsDgr.ItemsSource = context.Products.ToList();
        }
    }
}
