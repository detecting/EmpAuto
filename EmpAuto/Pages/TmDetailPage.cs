using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EmployerAutomation.Data;
using EmployerAutomation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EmpAuto.Pages
{
    class TmDetailPage
    {
        public TmDetailPage()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span")]
        public IWebElement TypeCode { get; set; }

        [FindsBy(How = How.Id, Using = "Code")]
        public IWebElement Code { get; set; }

        [FindsBy(How = How.Id, Using = "Description")]
        public IWebElement Description { get; set; }

        [FindsBy(How = How.Id, Using = "Price")]
        public IWebElement Price { get; set; }

        [FindsBy(How = How.Id, Using = "files")]
        public IWebElement SelectFile { get; set; }

        [FindsBy(How = How.Id, Using = "SaveButton")]
        public IWebElement Save { get; set; }


        public TmCreatePage FillTheForm()
        {
            TypeCode.Click();
            Thread.Sleep(1000);
            for (int i = 1; i <= 2; i++)
            {
                if (Properties.driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[" + i + "]")).Text ==
                    Properties.seletectedText)
                    Properties.driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[" + i + "]")).Click();
            }

            Code.SendKeys(Properties.code);
            Description.SendKeys(Properties.description);
            Save.Click();
            return new TmCreatePage();

        }
    }
}