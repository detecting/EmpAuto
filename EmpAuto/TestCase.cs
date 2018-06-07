using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployerAutomation.Data;
using EmployerAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace EmployerAutomation
{
    public class TestCase
    {
        [SetUp]
        public void Setup()
        {
            PublicMethods.Methods.Initial();
        }

        [Test]
        public void Login()
        {
            //login
            LoginPage loginPage = new LoginPage();
            HomePage home = loginPage.Login(Properties.userName, Properties.password);
            Assert.AreEqual(Properties.driver.Url, Properties.homeUrl);
            //HomePage
            EmployeersCreatePage employeersPage = home.employeeSelect();
        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}