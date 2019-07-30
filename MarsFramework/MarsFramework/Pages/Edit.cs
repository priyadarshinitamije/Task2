using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MarsFramework.Global;
using RelevantCodes.ExtentReports;

namespace MarsFramework.Pages
{
    class Edit
    {

        //function for edit language

        public Edit()
        {
            PageFactory.InitElements(GlobalDefinitions.Driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement ManageListing { get; set; }


        [FindsBy(How = How.XPath, Using = "//I[@class='outline write icon']")]
        private IWebElement EditIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'One-off service')]")]
        private IWebElement Service { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='ui teal button']")]
        private IWebElement Save { get; set; }


        //for verify
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Manage Listings')]")]
        private IWebElement ManagelistingsMenu { get; set; }

        //[FindsBy(How = How.XPath, Using = "//label[contains(text(),'Hourly basis service')]")]
        //private IWebElement ActualResult1 { get; set; }



        public void EditData()
        {


            Thread.Sleep(7000);
            ManageListing.Click();

            Thread.Sleep(7000);
            EditIcon.Click();

            Thread.Sleep(7000);
            Service.Click();

            Thread.Sleep(6000);
            Save.Click();


            //verify
            Thread.Sleep(9000);
            ManagelistingsMenu.Click();
            Thread.Sleep(9000);
            try
            {
                Console.WriteLine("Entered try");
                EditIcon.Click();

                //if selected true
                Assert.IsFalse(Service.Selected);
                {
                    Console.WriteLine("Test case 2 PASS : Record not edited");
                    Base.test.Log(LogStatus.Info, "Editing Done");
                }




                ////Screenshot
                //String img = Global.GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.Driver, "Report");   
                ////AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
                //Base.test.Log(LogStatus.Info, "Image example: " + img);
                //// end test. (Reports)
                //Base.extent.EndTest(Base.test);
                //// calling Flush writes everything to the log file (Reports)
                //Base.extent.Flush();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }
    }
}





