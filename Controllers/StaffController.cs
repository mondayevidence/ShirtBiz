using Newtonsoft.Json;
using ShirtBiz.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtBiz.Controllers
{
    class StaffController
    {
        WebService webservice;
        public StaffController()
        {
            webservice = new WebService();
        }

        public async Task<List<Models.Staff>> GetStaff()
        {
            string response = await webservice.GetRequest("https://jsonplaceholder.typicode.com/");
            List<Staff> staff = JsonConvert.DeserializeObject<List<Staff>>(response);
            foreach (var item in staff)
            {
                Debug.WriteLine(item.Address);
            }

            return staff;
        }
         /*public async Task<List<Staff>> PostStaff()
          {
              var staffdetails = new Dictionary<string, string>
             {
                 {"name:", "John doe" },
                 {"phone:", "08077375974" },
                 {"email:", "johndoe@gmail.ccom"},
                 {"address:", "bekham street, United Kingdom" },
                 {"dob:", "6-15-18"},
                 {"id:", "#575"},
                 {"datetime:", "17:00"}
              };
              string postResponse = await webservice.PostRequest("https://chikini-moni.firebaseio.com/employes/", staffdetails);
              List<Staff> staff = JsonConvert.DeserializeObject<List<Staff>>(postResponse);
          }*/
    }

}
