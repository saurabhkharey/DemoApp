using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApplication2.Models;
using System.Web.Script.Serialization;

namespace WebApplication2.Html
{
    /// <summary>
    /// Summary description for EmployeeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class EmployeeService : System.Web.Services.WebService
    {

        [WebMethod]
        public void GetAllEmployees()
        {
            List<Employee> LST = new List<Employee> {
                new Employee { Name = "Saurabh", Gender = "M", Salary = 11000 },
                new Employee { Name = "Gaurav", Gender = "M", Salary = 11500 },
                new Employee { Name = "Sushil", Gender = "M", Salary = 11700 }
            };

            JavaScriptSerializer JS = new JavaScriptSerializer();
            Context.Response.Write(JS.Serialize(LST));
        }
    }
}
