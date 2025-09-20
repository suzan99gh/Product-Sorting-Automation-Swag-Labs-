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
        FilterTest_POM FilterTest_POM = new FilterTest_POM(ManageDriver.driver);
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
            Console.WriteLine("Products on page:");
            foreach (var name in actualNames)
            {
                Console.WriteLine(name);
            }
            List<string> expectedNames = actualNames.OrderBy(n => n).ToList();
            CollectionAssert.AreEqual(expectedNames, actualNames, "Products are not sorted A to Z");
            Console.WriteLine("Test completed Successfully");
        }

        [TestMethod]
        public void ZtoA()
        {
            CommonMethods.NavigateToURL(GlobalConstant.LoginLink);
            ManageDriver.MaximizeDriver();
            Login_AssistantMethods.UserLogin(); // تأكد إنه ناجح

            FilterTest_AssistantMethods.ZtoAoption();

            //// اختيار فلتر Z → A
            //var select = new SelectElement(ManageDriver.driver.FindElement(By.ClassName("product_sort_container")));
            //select.SelectByValue("za"); // القيمة الصحيحة للـ Z → A

            // جلب أسماء المنتجات
            var productElements = ManageDriver.driver.FindElements(By.ClassName("inventory_item_name"));
            List<string> actualNames = productElements.Select(e => e.Text).ToList();

            Console.WriteLine("Products on page:");
            //foreach (var name in actualNames)
            //{
            //    Console.WriteLine(name);
            //}

            // تجهيز النسخة المتوقعة (مرتبة Z → A)
            List<string> expectedNames = actualNames.OrderByDescending(n => n).ToList();
            foreach (var name in expectedNames)
            {
                Console.WriteLine("Actual :"+name);
            }
            // Assert
            CollectionAssert.AreEqual(expectedNames, actualNames, "Products are not sorted Z to A");

            Console.WriteLine("Test completed Successfully");
        }

        [TestMethod]
        public void PriceLowToHigh()
        {
            CommonMethods.NavigateToURL(GlobalConstant.LoginLink);
            ManageDriver.MaximizeDriver();
            Login_AssistantMethods.UserLogin();
            FilterTest_AssistantMethods.ASCoption();    
            var priceElements = ManageDriver.driver.FindElements(By.ClassName("inventory_item_price"));
            List<decimal> actualPrices = priceElements
                                         .Select(e => Decimal.Parse(e.Text.Replace("$", "")))
                                         .ToList();

            Console.WriteLine("Prices on page:");
            foreach (var price in actualPrices)
            {
                Console.WriteLine(price);
            }

            List<decimal> expectedPrices = actualPrices.OrderBy(p => p).ToList();
            CollectionAssert.AreEqual(expectedPrices, actualPrices, "Products are not sorted by Price Low to High");
            Console.WriteLine("Test completed Successfully");
        }

        [TestMethod]
        public void PriceHighToLow()
        {
            CommonMethods.NavigateToURL(GlobalConstant.LoginLink);
            ManageDriver.MaximizeDriver();
            Login_AssistantMethods.UserLogin();
            FilterTest_AssistantMethods.DESCoption();
            var select = new SelectElement(ManageDriver.driver.FindElement(By.ClassName("product_sort_container")));
            select.SelectByValue("hilo"); 

            var priceElements = ManageDriver.driver.FindElements(By.ClassName("inventory_item_price"));
            List<decimal> actualPrices = priceElements
                                         .Select(e => Decimal.Parse(e.Text.Replace("$", "")))
                                         .ToList();

            Console.WriteLine("Prices on page:");
            foreach (var price in actualPrices)
            {
                Console.WriteLine(price);
            }
            List<decimal> expectedPrices = actualPrices.OrderByDescending(p => p).ToList();
            CollectionAssert.AreEqual(expectedPrices, actualPrices, "Products are not sorted by Price High to Low");

            Console.WriteLine("Test completed Successfully");
        }

    }
}
