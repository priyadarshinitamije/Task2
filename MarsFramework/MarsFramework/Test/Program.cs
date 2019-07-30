using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsFramework.Pages;


namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class Tenant : Global.Base
        {

            //[Test]
            //public void UserAccount()
            //{
            //    // Creates a toggle for the given test, adds all log events under it    
            //    test = extent.StartTest("Search for a Property");

            //    // Create an class and object to call the method
            //    Profile obj = new Profile();
            //    obj.EditProfile();

            //}

            [Test]
            public void AddShareSkill()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Adding skillListing");

                ShareListing obj2 = new ShareListing();
                obj2.ListingSteps();

            }
            [Test]
            public void EditSkill()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Editing skillListing");

                Edit obj3 = new Edit();
                obj3.EditData();
            }


            [Test]
            public void DelSkill()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Deleting skillListing");

                Delete obj4 = new Delete();
                obj4.DeleteData();
            }

        }
    }
}