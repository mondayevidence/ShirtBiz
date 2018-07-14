using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ShirtBiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ProductContext1 _context = new ProductContext1();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource categoryViewSource =
                ((System.Windows.Data.CollectionViewSource)(this.FindResource("categoryViewSource")));
            categoryViewSource.Source = _context.Categories.Local;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(var product in _context.Products.Local.ToList())
            {
                if(product.Category == null)
                {
                    _context.Products.Remove(product);
                }
            }
            _context.SaveChanges();
            this.categoryDataGrid.Items.Refresh();
            this.productDataGrid.Items.Refresh();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._context.Dispose();
        }
    }
}
