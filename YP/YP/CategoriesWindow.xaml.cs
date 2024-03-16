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
    public partial class CategoriesWindow : Window
    {
        private CategoriesTableAdapter categories = new CategoriesTableAdapter();
        public CategoriesWindow()
        {
            InitializeComponent();
            CategoriesDataGrid.ItemsSource = categories.GetData();
        }
    }
}
