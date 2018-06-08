using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EmployerAutomation.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EmployerAutomation.Pages
{
    class HomePage
    {

        public HomePage()
        {
            PageFactory.InitElements(Properties.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/ul/li[5]/a")]
        public IWebElement Administration { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")]
        public IWebElement Tm { get; set; }

        public TmCreatePage employeeSelect()
        {
            Administration.Click();
            Thread.Sleep(1000);
            Tm.Click();
            return new TmCreatePage();
        }

    }
}