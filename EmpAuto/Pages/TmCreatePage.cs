using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using EmpAuto.Pages;
using EmployerAutomation.Data;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EmployerAutomation.Pages
{
    class TmCreatePage
    {
        public TmCreatePage()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"tmsGrid\"]/div[3]/table/tbody")]
        public IWebElement Table { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"container\"]/p/a")]
        public IWebElement CreateNew { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")]
        public IWebElement LastPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"tmsGrid\"]/div[4]/a[2]/span")]
        public IWebElement PreviousPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"tmsGrid\"]/div[4]/ul")]
        public IWebElement PageNumber { get; set; }


        //edit and  delete will implement later.

        public TmDetailPage Create()
        {
            CreateNew.Click();
            return new TmDetailPage();
        }

        public void CheckRecords()
        {
            //go to the last page and click 
            Thread.Sleep(1000);
            LastPage.Click();
            Thread.Sleep(1500);

            //get the maxmun value of the page:
            //get the text of ul
            string pageNumber = PageNumber.Text;


            //split pageNumber into string arr
            string[] arrPage = pageNumber.Split(Environment.NewLine.ToCharArray());

            //browser each page from last page to the first page
            for (int i = 1; i < int.Parse(arrPage[arrPage.Length - 1]); i++)
            {
                //the current page number
                int pageNow = int.Parse(arrPage[arrPage.Length - 1]) - i + 1;
                Thread.Sleep(1000);

                //get the table and tr location 
                var trs
                    = Table.FindElements(By.TagName("tr"));

                // go through all the tr in table
                foreach (var tr in trs)
                {
                    //get td in this tr
                    var tds = tr.FindElements(By.TagName("td"));

                    //get the text of each td and conpare to what you want
                    foreach (var td in tds)
                    {
                        string tdString = td.Text;
                        if (tdString == Properties.code)
                        {
                            Console.WriteLine("PASS----Find the input Code on page :" + pageNow);
                        }
                    }
                }

                //go to the previous page
                PreviousPage.Click();
            }
        }
        public void DeleteRecords()
        {
            //go to the last page and click 
            Thread.Sleep(1000);
            LastPage.Click();
            Thread.Sleep(1500);

            //get the maxmun value of the page:
            //get the text of ul
            string pageNumber = PageNumber.Text;


            //split pageNumber into string arr
            string[] arrPage = pageNumber.Split(Environment.NewLine.ToCharArray());

            //browser each page from last page to the first page
            for (int i = 1; i < int.Parse(arrPage[arrPage.Length - 1]); i++)
            {
                //the current page number
                int pageNow = int.Parse(arrPage[arrPage.Length - 1]) - i + 1;
                Thread.Sleep(1000);

                //get the table and tr location 
                var trs
                    = Table.FindElements(By.TagName("tr"));

                // go through all the tr in table
                foreach (var tr in trs)
                {
                    Thread.Sleep(1000);
                    //get td in this tr
                    var tds = tr.FindElements(By.TagName("td"));

                    //get the text of each td and conpare to what you want
                    foreach (var td in tds)
                    {
                        string tdString = td.Text;

                        //find the record row
                        if (tdString == Properties.code)
                        {
                            //click and the alert shows up 相对路径
                            tr.FindElement(By.XPath(".//td[5]/a[2]")).Click();
                            //move to alert
                            IAlert iAlert = Properties.driver.SwitchTo().Alert();
                            //click OK
                            iAlert.Accept();
                            Console.WriteLine("Delete" + pageNow);
                            Thread.Sleep(1000);
                            return;
                        }
                    }
                }

                //go to the previous page
                PreviousPage.Click();
            }
        }

    }
}

