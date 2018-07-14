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
using System.Net.Http;
using System.Net.Http.Headers;

namespace ShirtBiz.Views
{
    /// <summary>
    /// Interaction logic for StaffView.xaml
    /// </summary>
    public partial class StaffView : Window
    {
        public string Address { get; private set; }       
        public string Designation { get; private set; }
        public int Id { get; private set; }
        public StaffView()
        {
            InitializeComponent();
        }
  
       
        private void BindStaffList()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:12789/");

            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/staff").Result;
            if (response.IsSuccessStatusCode)
            {
                var staffview = response.Content.ReadAsAsync<IEnumerable<StaffView>>().Result;
                grdEmployee.ItemsSource = staffview;
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)

        {
            BindStaffList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:12789/");
            client.DefaultRequestHeaders.Accept.Add(

               new MediaTypeWithQualityHeaderValue("application/json"));

            var staff = new StaffView();

            staff.Id = int.Parse(txtId.Text);
            staff.Name = txtName.Text;
            staff.Address = txtAddress.Text;
            staff.Designation = txtDesignation.Text;

            var response = client.PostAsJsonAsync("api/staff", staff).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("StaffAdded");
                txtId.Text = "";
                txtName.Text = "";
                txtAddress.Text = "";
                txtDesignation.Text = "";
                BindStaffList();
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:12789/");
            var id = txtId.Text.Trim();
            var url = "api/staff/" + id;
            HttpResponseMessage response = client.DeleteAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Staff Deleted");
                BindStaffList();
            }
            else
           {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:12789/");
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            var id = txtId.Text.Trim();
            var url = "api/staff/" + id;

            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                var staff = response.Content.ReadAsAsync<StaffView>().Result;
                MessageBox.Show("Staff Found : " + staff.Name + " " + staff.Address + " " + staff.Designation + " " + staff.Id);
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
    }
}
