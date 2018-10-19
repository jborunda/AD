using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AD.Models;
using System.DirectoryServices;



namespace AD.Controllers
{
    public class HomeController : Controller
    {
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
                Debug.WriteLine("try");

                DirectoryEntry dirEntry = new DirectoryEntry("LDAP://" + ad.domain, ad.userName, ad.password); Debug.WriteLine(dirEntry);

                DirectorySearcher dirSearch = new DirectorySearcher(dirEntry, "(objectClass=user)"); Debug.WriteLine(dirSearch);
                dirSearch.Filter = String.Format("(&(SAMAccountName={0}))", ad.userName);
                dirSearch.PropertiesToLoad.Add("givenName");
                dirSearch.PropertiesToLoad.Add("mail");
                dirSearch.PropertiesToLoad.Add("cn");                          //'Full Name + EmpNo
                dirSearch.PropertiesToLoad.Add("SAMAccountName");              //'EMPNO
                dirSearch.PropertiesToLoad.Add("givenName");             //'First Name
                dirSearch.PropertiesToLoad.Add("sn");                  //'Last Name
                dirSearch.PropertiesToLoad.Add("mail");                        //'Email
                dirSearch.PropertiesToLoad.Add("title");                       //'job title
                dirSearch.PropertiesToLoad.Add("department");                  //'Department
                dirSearch.PropertiesToLoad.Add("telephoneNumber");             //'Telephone
                dirSearch.PropertiesToLoad.Add("physicalDeliveryOfficeName");  //'Area Office
                dirSearch.PropertiesToLoad.Add("streetAddress"); //'Area Office address
                dirSearch.PropertiesToLoad.Add("l");                             //'city
                dirSearch.PropertiesToLoad.Add("st");                          //'state
                dirSearch.PropertiesToLoad.Add("postalCode");                  //'zipcode
                dirSearch.PropertiesToLoad.Add("Manager");                     //'manager

                SearchResult objResult = dirSearch.FindOne();

                if (objResult.GetDirectoryEntry().Properties["samaccountname"].Value != null)
                {
                   // employee.samAcct = "Username : " + objResult.GetDirectoryEntry().Properties["samaccountname"].Value.ToString();
                }

                if (objResult.GetDirectoryEntry().Properties["givenName"].Value != null)
                {
                    employee.First_Name = "First Name : " + objResult.GetDirectoryEntry().Properties["givenName"].Value.ToString();
                }
                if (objResult.GetDirectoryEntry().Properties["sn"].Value != null)
                {
                    employee.Last_Name = "Last Name : " + objResult.GetDirectoryEntry().Properties["sn"].Value.ToString();
                }

                if (objResult.GetDirectoryEntry().Properties["mail"].Value != null)
                {
                    employee.Email = "Email ID : " + objResult.GetDirectoryEntry().Properties["mail"].Value.ToString();
                }


            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                return Content(ex.ToString());
            }
            return Content(employee.Email + employee.First_Name + employee.Last_Name);
        }
    }
}
    
    
/*
givenName = objResult.Properties("givenName")[0];
                Session("Last_Name") = SResult.Properties("sn")(0).ToString()
                Session("Email") = SResult.Properties("mail")(0).ToString() & ""
                Session("Employee_Number") = SResult.Properties("SAMAccountName")(0).ToString() & ""
                Session("Username") = strUsername
                */


/*
Try
            DirectoryEntry DEntry = New DirectoryEntry(strADFullPath, strUsername, strPassword)
            DirectorySearcher dirSearch = New DirectorySearcher(DEntry)
            'dirSearch.Filter = String.Format("(&(SAMAccountName={0}) (department=Probation #640))", strUsername)
            dirSearch.Filter = String.Format("(&(SAMAccountName={0}))", strUsername)
            dirSearch.PropertiesToLoad.Add("cn")                          'Full Name + EmpNo
            dirSearch.PropertiesToLoad.Add("SAMAccountName")              'EMPNO
            dirSearch.PropertiesToLoad.Add("givenName")                   'First Name
            dirSearch.PropertiesToLoad.Add("sn")                          'Last Name
            dirSearch.PropertiesToLoad.Add("mail")                        'Email
            dirSearch.PropertiesToLoad.Add("title")                       'job title
            dirSearch.PropertiesToLoad.Add("department")                  'Department
            dirSearch.PropertiesToLoad.Add("telephoneNumber")             'Telephone
            dirSearch.PropertiesToLoad.Add("physicalDeliveryOfficeName")  'Area Office
            dirSearch.PropertiesToLoad.Add("streetAddress")               'Area Office address
            dirSearch.PropertiesToLoad.Add("l")                           'city
            dirSearch.PropertiesToLoad.Add("st")                          'state
            dirSearch.PropertiesToLoad.Add("postalCode")                  'zipcode
            dirSearch.PropertiesToLoad.Add("Manager")                     'manager

    */

/*
 * 
 * 
            dirSearch.Filter = "(&((&(objectCategegory=Person)(objectClass=User)))(samaccountname=" + ad.userName + "))";
            dirSearch.SearchScope = SearchScope.Subtree;
            
 * try
            {
                    
            SearchResult objResult = dirSearch.FindOne();
            Debug.WriteLine("***" + objResult);
            if (objResult.GetDirectoryEntry().Properties["samaccountname"].Value != null)
                samAcct = "Username : " + objResult.GetDirectoryEntry().Properties["samaccountname"].Value.ToString();
            Debug.WriteLine("***" + objResult.GetDirectoryEntry().Properties["samaccountname"].Value);
            if (objResult.GetDirectoryEntry().Properties["givenName"].Value != null)
                givenName = "First Name : " + objResult.GetDirectoryEntry().Properties["givenName"].Value.ToString();

            if (objResult.GetDirectoryEntry().Properties["sn"].Value != null)
                lastName = "Last Name : " + objResult.GetDirectoryEntry().Properties["sn"].Value.ToString();

            if (objResult.GetDirectoryEntry().Properties["mail"].Value != null)
                mail = "Email ID : " + objResult.GetDirectoryEntry().Properties["mail"].Value.ToString();
            return Content(givenName,mail);
            } catch (Exception)
            {
               Console.WriteLine("Exception error");
            }
*/
