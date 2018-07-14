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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        NewUser newUser;
        CustomerTab customerTab;
        LoginScreen staffLogin;
        Product product;
        Settings settings;
        Profile profile;
        Delivery delivery;

        public Dashboard()
        {
            InitializeComponent();
        }
        
        private void staffBtn_Click(object sender, RoutedEventArgs e)
        {
            staffLogin = new LoginScreen();
            staffLogin.Show();
            Close();
        }

        private void profileBtn_Click(object sender, RoutedEventArgs e)
        {
            profile = new Profile();
            profile.Show();
            Close();
        }

        private void tablesBtn_Click(object sender, RoutedEventArgs e)
        {
            customerTab = new CustomerTab();
            customerTab.Show();
            Close();
        }

        private void deliveryBtn_Click(object sender, RoutedEventArgs e)
        {
            delivery = new Delivery();
            delivery.Show();
            Close();
        }

        private void productBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void settingBtn_Click(object sender, RoutedEventArgs e)
        {
            settings = new Settings();
            settings.Show();
            Close();
        }

        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            newUser = new NewUser();
            newUser.Show();
            Close();
        }

        private void btnPower_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridTitle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }



    }

    
}
