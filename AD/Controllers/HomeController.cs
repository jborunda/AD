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
            Debug.WriteLine("33");
            DirectorySearcher dirSearch = null;
            string givenName = "";
            string mail = "";
            string sn = "";
            Debug.WriteLine(ad.domain);

            if (dirSearch == null)
            {
                DirectoryEntry dirEntry = new DirectoryEntry(ad.domain, ad.userName, ad.password);
                dirSearch = new DirectorySearcher(dirEntry);

                dirSearch.Filter = "(&((&(objectCategegory=Person)(objectClass=User)))(samaccountname=" + ad.userName + "))";
                dirSearch.SearchScope = SearchScope.Subtree;
                
                try
                {
                    
                    SearchResult userObject = dirSearch.FindOne();
                    Debug.WriteLine("***" + userObject);
                    if (userObject.GetDirectoryEntry().Properties["samaccountname"].Value != null)
                        givenName = "Username : " + userObject.GetDirectoryEntry().Properties["samaccountname"].Value.ToString();
                    Debug.WriteLine("***" + userObject.GetDirectoryEntry().Properties["samaccountname"].Value);
                    if (userObject.GetDirectoryEntry().Properties["givenName"].Value != null)
                        givenName = "First Name : " + userObject.GetDirectoryEntry().Properties["givenName"].Value.ToString();

                    if (userObject.GetDirectoryEntry().Properties["sn"].Value != null)
                        sn = "Last Name : " + userObject.GetDirectoryEntry().Properties["sn"].Value.ToString();

                    if (userObject.GetDirectoryEntry().Properties["mail"].Value != null)
                        mail = "Email ID : " + userObject.GetDirectoryEntry().Properties["mail"].Value.ToString();
                    return Content(givenName);
                } catch (Exception)
                {
                    Console.WriteLine("Exception error");
                }

                
                
            }

        return Content("nothing happen");
        }
    }
}
