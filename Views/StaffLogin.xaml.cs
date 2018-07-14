using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
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
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        //SQLite objects
        
        SQLiteCommand cmd;
        MySqlDataAdapter adapter;
        DataTable table;
        /*string dbConnectionString = @"DataSource=C:\Users\monda\Documents\Visual Studio 2015\Projects\ShirtBiz\users.db;Version=3;New=False;Compress=True";*/
        public LoginScreen()
        {
            InitializeComponent();        
        }
        /*SqlConnection Conn = new SqlConnection("dbConnectionString;");*/

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            using (var Conn = new SQLiteConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\monda\Documents\Staff.mdf;Integrated Security=True;Connect Timeout=30; Version = 3; New = False; Compress = True;"))
              {
                  Conn.Open();                

                  using(var cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS [Staff] (id INTEGER PRIMARY KEY AUTOINCREAMENT, 'Username' TEXT, 'Age' INTEGER );", Conn))
                  {
                      cmd.ExecuteNonQuery();
                  }

                  try
                  {
                      if (Conn.State == ConnectionState.Closed)
                          Conn.Open();

                      string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username AND Password = @Password";
                      cmd = new SQLiteCommand(query, Conn);
                      cmd.CommandType = CommandType.Text;
                      cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                      cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                      int count = Convert.ToInt32(cmd.ExecuteScalar());

                      if (count == 1)
                      {
                          Dashboard dashboard = new Dashboard();
                          dashboard.Show();
                          this.Close();
                      }
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show(ex.Message);
                  }
                  finally
                  {

                  }
              }
            //populate the datagridview
            /*string selectQuery = "SELECT * users";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);*/
        }
    }
}
