using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EmployerAutomation.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EmpAuto.Pages
{
    class EmployeeDetailPage
    {
        public EmployeeDetailPage()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        [FindsBy(How = How.Id, Using = "Name")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.Id, Using = "Username")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "ContactDisplay")]
        public IWebElement ContactDisplay { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "RetypePassword")]
        public IWebElement RetypePassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"UserEditForm\"]/div/div[6]/label")]
        public IWebElement IsAdmin { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input")]
        public IWebElement VehicleId { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]")]
        public IWebElement Groups { get; set; }

        [FindsBy(How = How.Id, Using = "SaveButton")]
        public IWebElement SaveButton { get; set; }
    }
}