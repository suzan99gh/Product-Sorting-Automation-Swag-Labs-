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
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using Swag_Labs_Filters.AssistantMethods;
using OpenQA.Selenium;
using Swag_Labs_Filters.POM;

namespace SwagLabs.TestMethods
{
    [TestClass]
    public class TestMethode
    {
        private IWebDriver webDriver;

        public TestMethode(IWebDriver driver)
        {
            webDriver = driver;
        }

        [TestMethod]
        //[Priority(1)]
        public void AtoZ()
        {
            try
            {
                CommonMethods.NavigateToURL(GlobalConstant.LoginLink);
                ManageDriver.MaximizeDriver();
                Login_AssistantMethods.UserLogin();
                FilterTest_AssistantMethods.AtoZoption();

                //var productElements = webDriver.FindElements(By.ClassName("inventory_item_name"));
                //List<string> actualNames = productElements.Select(e => e.Text).ToList();
                
                //Console.WriteLine(actualNames);
                //List<string> expectedNames = actualNames.OrderByDescending(n => n).ToList();
                //Console.WriteLine(expectedNames);
                // Assert
                //CollectionAssert.AreEqual(expectedNames, actualNames, "Products are not sorted Z to A");

                

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
