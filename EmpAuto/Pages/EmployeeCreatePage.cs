using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpAuto.Pages;
using EmployerAutomation.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EmployerAutomation.Pages
{
    class EmployeersCreatePage
    {
        public EmployeersCreatePage()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"usersGrid\"]/div[3]/table/tbody")]
        public IWebElement Table { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"container\"]/p/a")]
        public IWebElement Create { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"usersGrid\"]/div[4]/a[4]/span")]
        public IWebElement LastPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"usersGrid\"]/div[4]/ul")]
        public IWebElement PageNumber { get; set; }


        //edit and  delete will implement later.

        public EmployeeDetailPage CreateEmployee()
        {
            Create.Click();
            return new EmployeeDetailPage();
        }
    }
}