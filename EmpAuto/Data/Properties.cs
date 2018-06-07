using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace EmployerAutomation.Data
{
    static class Properties
    {
        public static string loginUrl = "http://horse-dev.azurewebsites.net/Account/Login";
        public static IWebDriver driver;
        public static string userName = "ray";
        public static string password = "123123";
        public static string homeUrl = "http://horse-dev.azurewebsites.net/";

    }
}