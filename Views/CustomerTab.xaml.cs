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

namespace ShirtBiz.Views
{
    /// <summary>
    /// Interaction logic for CustomerTab.xaml
    /// </summary>
    public partial class CustomerTab : Window
    {
        public CustomerTab()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($" This Description is: {this.DescriptionText.Text}");
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            this.abujaChk.IsChecked = this.abeokutaChk.IsChecked = this.calabarChk.IsChecked = this.lekkiChk.IsChecked = this.phChk.IsChecked =
                this.capetownChk.IsChecked = this.accraChk.IsChecked = this.asabaChk.IsChecked = this.onitshaChk.IsChecked = this.lagosChk.IsChecked = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
