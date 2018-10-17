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
            
            string givenName = "";
            string mail = "";
            string lastName = "";
            string samAcct = "";
            Debug.WriteLine(ad.domain);
            Debug.WriteLine(ad.userName);
            


            try
            {
                                                                                                                            
                DirectoryEntry dirEntry = new DirectoryEntry("LDAP://" + ad.domain, ad.userName, ad.password);              Debug.WriteLine(dirEntry);

                DirectorySearcher dirSearch = new DirectorySearcher(dirEntry);                                              Debug.WriteLine(dirSearch);
                dirSearch.Filter = String.Format("(&(SAMAccountName={0}))", ad.userName);

                dirSearch.PropertiesToLoad.Add("givenName");

                SearchResult objResult = dirSearch.FindOne();
                                 
                
                


              

            }
            catch (System.Runtime.InteropServices.COMException)
            {
                                                                                                                            Debug.WriteLine("try");
                return Content("System.Runtime.InteropServices.COMException");
            }
            
            return Content("controller ends ");
        
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
                    
            SearchResult userObject = dirSearch.FindOne();
            Debug.WriteLine("***" + userObject);
            if (userObject.GetDirectoryEntry().Properties["samaccountname"].Value != null)
                samAcct = "Username : " + userObject.GetDirectoryEntry().Properties["samaccountname"].Value.ToString();
            Debug.WriteLine("***" + userObject.GetDirectoryEntry().Properties["samaccountname"].Value);
            if (userObject.GetDirectoryEntry().Properties["givenName"].Value != null)
                givenName = "First Name : " + userObject.GetDirectoryEntry().Properties["givenName"].Value.ToString();

            if (userObject.GetDirectoryEntry().Properties["sn"].Value != null)
                lastName = "Last Name : " + userObject.GetDirectoryEntry().Properties["sn"].Value.ToString();

            if (userObject.GetDirectoryEntry().Properties["mail"].Value != null)
                mail = "Email ID : " + userObject.GetDirectoryEntry().Properties["mail"].Value.ToString();
            return Content(givenName,mail);
            } catch (Exception)
            {
               Console.WriteLine("Exception error");
            }
*/
