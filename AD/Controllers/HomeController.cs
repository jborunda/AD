using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AD.Models;
using System.DirectoryServices; 

//using System.DirectoryServices.AccountManagement;


namespace AD.Controllers
{
    public class HomeController : Controller
    {
        
        public readonly ADContext _context;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]
        [Route("Home/Login/")]
        public IActionResult Login()
        {
               return View();
        }


        [HttpPost]
        public IActionResult Login(AD_info ad)
        {


            Employee employee = new Employee();


            try
            {
                
                DirectoryEntry dirEntry = new DirectoryEntry("LDAP://" + ad.domain, ad.userName, ad.password); 

                DirectorySearcher dirSearch = new DirectorySearcher(dirEntry, "(objectClass=user)");
                

                dirSearch.Filter = String.Format("(&(SAMAccountName={0}))", ad.userName);
                dirSearch.PropertiesToLoad.Add("givenName");
                dirSearch.PropertiesToLoad.Add("mail");
                dirSearch.PropertiesToLoad.Add("cn");                           //'Full Name + EmpNo
                dirSearch.PropertiesToLoad.Add("SAMAccountName");               //'EMPNO
                dirSearch.PropertiesToLoad.Add("givenName");                    //'First Name
                dirSearch.PropertiesToLoad.Add("sn");                           //'Last Name
                dirSearch.PropertiesToLoad.Add("mail");                         //'Email
                dirSearch.PropertiesToLoad.Add("title");                        //'job title
                dirSearch.PropertiesToLoad.Add("department");                   //'Department
                dirSearch.PropertiesToLoad.Add("telephoneNumber");              //'Telephone
                dirSearch.PropertiesToLoad.Add("physicalDeliveryOfficeName");   //'Area Office
                dirSearch.PropertiesToLoad.Add("streetAddress");                //'Area Office address
                dirSearch.PropertiesToLoad.Add("l");                            //'city
                dirSearch.PropertiesToLoad.Add("st");                           //'state
                dirSearch.PropertiesToLoad.Add("postalCode");                   //'zipcode
                dirSearch.PropertiesToLoad.Add("Manager");                      //'manager

                SearchResult objResult = dirSearch.FindOne();

                if (objResult.GetDirectoryEntry().Properties["samaccountname"].Value != null)
                {
                    employee.Employee_Number = "Username : " + objResult.GetDirectoryEntry().Properties["samaccountname"].Value.ToString();
                }

                if (objResult.GetDirectoryEntry().Properties["givenName"].Value != null)
                {
                    employee.First_Name = objResult.GetDirectoryEntry().Properties["givenName"].Value.ToString();
                }
                if (objResult.GetDirectoryEntry().Properties["sn"].Value != null)
                {
                    employee.Last_Name = objResult.GetDirectoryEntry().Properties["sn"].Value.ToString();
                }

                if (objResult.GetDirectoryEntry().Properties["mail"].Value != null)
                {
                    employee.Email = objResult.GetDirectoryEntry().Properties["mail"].Value.ToString();
                }
                if (objResult.GetDirectoryEntry().Properties["title"].Value != null)
                {
                    employee.Payroll_Title = objResult.GetDirectoryEntry().Properties["title"].Value.ToString();
                }
                if (objResult.GetDirectoryEntry().Properties["department"].Value != null)
                {
                    employee.Department = objResult.GetDirectoryEntry().Properties["department"].Value.ToString();
                }
                if (objResult.GetDirectoryEntry().Properties["telephoneNumber"].Value != null)
                {
                    employee.Cell_Phone = objResult.GetDirectoryEntry().Properties["telephoneNumber"].Value.ToString();
                }
                if (objResult.GetDirectoryEntry().Properties["physicalDeliveryOfficeName"].Value != null)
                {
                    employee.Employee_Number = objResult.GetDirectoryEntry().Properties["physicalDeliveryOfficeName"].Value.ToString();
                }
                if (objResult.GetDirectoryEntry().Properties["streetAddress"].Value != null)
                {
                    employee.Work_address = objResult.GetDirectoryEntry().Properties["streetAddress"].Value.ToString();
                }

                
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                return Content(ex.ToString());
            }

            return Content(employee.Last_Name + employee.Email + employee.Payroll_Title + employee.Department + employee.Cell_Phone + employee.Work_address + employee.Department + "mail: " + employee.Email + " first name: " + employee.First_Name + " last name: " + employee.Last_Name + " employee id: " + employee.Employee_ID + " Admin_flag :" + employee.Admin_Flag);

        }
    }
}