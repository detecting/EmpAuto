using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployerAutomation.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EmployerAutomation.Pages
{
    class LoginPage
    {

        [FindsBy(How = How.Id, Using = "UserName")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"loginForm\"]/form/div[3]/input[1]")]
        public IWebElement LoginBtn { get; set; }

        public LoginPage()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        public HomePage Login(string userName, string password)
        {
            UserName.SendKeys(userName);
            Password.SendKeys(password);
            LoginBtn.Submit();
            return new HomePage();
        }
    }
}