using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployerAutomation.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployerAutomation.PublicMethods
{
    class Methods
    {
        public static void Initial()
        {

            Properties.driver = new ChromeDriver();
            Properties.driver.Navigate().GoToUrl(Properties.loginUrl);
        }
    }
}