using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Efwatercom.AssistantMethods;
using Efwatercom.Data;
using SwagLabs.Helpers;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Model;
using static System.Net.Mime.MediaTypeNames;
using SwagLabs.AssistantMethods;
using SwagLabs.POM;

namespace SwagLabs.TestMethods
{
    [TestClass]
    public class TestMethode
    {

        [TestMethod]
        //[Priority(1)]
        public void Login()
        {
            try
            {
                CommonMethods.NavigateToURL(GlobalConstant.LoginLink);
                ManageDriver.MaximizeDriver();
                Login_AssistantMethods.UserLogin();

               
            }
            catch (Exception ex)
            {
                Console.WriteLine("The issue is : " + ex.Message);
            }
        }

        //[ClassCleanup]
        //public static void ClassCleanup()
        //{
        //    ManageDriver.CloseDriver();

        //}
    } 
}
