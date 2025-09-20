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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;

namespace SwagLabs.TestMethods
{
    [TestClass]
    public class TestMethode
    {

        private IWebDriver webDriver;

        public TestMethode()
        {
            webDriver = ManageDriver.driver; // اسحب الـ driver من الكلاس المسؤول عنه
        }

        [TestMethod]
        public void AtoZ()
        {
            CommonMethods.NavigateToURL(GlobalConstant.LoginLink);
            ManageDriver.MaximizeDriver();
            Login_AssistantMethods.UserLogin();
          
            
            FilterTest_AssistantMethods.AtoZoption();

            var productElements = ManageDriver.driver.FindElements(By.ClassName("inventory_item_name"));
            List<string> actualNames = productElements.Select(e => e.Text).ToList();
            foreach (var name in actualNames)
            {
                Console.WriteLine(name);
            }

            List<string> expectedNames = actualNames.OrderBy(n => n).ToList();
            CollectionAssert.AreEqual(expectedNames, actualNames, "Products are not sorted A to Z");
            Console.WriteLine("Test completed Successfully");
        }

       
    }
}
