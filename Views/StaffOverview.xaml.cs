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
    /// Interaction logic for StaffDataGrid.xaml
    /// </summary>
    public partial class StaffDataGrid : Window
    {
        public StaffDataGrid()
        {
            InitializeComponent();
            StaffOverview johnDoe = new StaffOverview();

            johnDoe.staffID = "001";
            johnDoe.staffName = "JOHN DOE";
            johnDoe.staffAddress = "122 GRA";
            johnDoe.staffCity = "Ikeja";
            johnDoe.staffState = "Lagos";

            DataGridXAML.Items.Add(johnDoe);


            StaffOverview kristinJoe = new StaffOverview();

            kristinJoe.staffID = "002";
            kristinJoe.staffName = "KRISTIN JOE";
            kristinJoe.staffAddress = "133 GRA";
            kristinJoe.staffCity = "Lekki";
            kristinJoe.staffState = "Lagos";

            DataGridXAML.Items.Add(kristinJoe);

        }
        public class StaffOverview
        {
            public string staffID { get; set; }
            public string staffName { get; set; }
            public string staffAddress { get; set; }
            public string staffCity { get; set; }
            public string staffState { get; set; }
        }

        //Add new Staff Button
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            StaffOverview tempStaff = new StaffOverview();
            tempStaff.staffID = IDTb.Text;
            tempStaff.staffName = NameTb.Text;
            tempStaff.staffAddress = AddrTb.Text;
            tempStaff.staffCity = CityTb.Text;
            tempStaff.staffState = StateTb.Text;

            DataGridXAML.Items.Add(tempStaff);
        }
    }
}
