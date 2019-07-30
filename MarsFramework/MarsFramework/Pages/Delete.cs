using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class Delete
    {

        //function for edit language

        public Delete()
        {
            PageFactory.InitElements(GlobalDefinitions.Driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement ManageListing { get; set; }


        [FindsBy(How = How.XPath, Using = "//tr[1]//td[8]//i[3]")]
        private IWebElement DeleteIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='ui icon positive right labeled button']")]
        private IWebElement ConfirmYes { get; set; }

        //for verify
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Manage Listings')]")]
        private IWebElement ManagelistingsMenu { get; set; }

        //ActualResult3
        [FindsBy(How = How.XPath, Using = "//div[@class='ns-box-inner']")]
        private IWebElement ActResult3 { get; set; }


        public void DeleteData()
        {
            Thread.Sleep(7000);
            ManageListing.Click();

            Thread.Sleep(7000);
            DeleteIcon.Click();

            ConfirmYes.Click();
            Thread.Sleep(4000);

            //Verfication
            try
            {

                Assert.IsTrue(ActResult3.Displayed);
                Console.WriteLine("Test 3 Pass : Record deleted successfully");

                Base.test.Log(LogStatus.Info, "Deleting Done");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }

        }
    }
}
