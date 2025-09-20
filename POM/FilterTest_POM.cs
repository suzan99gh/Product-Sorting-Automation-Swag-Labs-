using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SwagLabs.Helpers;

namespace Swag_Labs_Filters.POM
{
    public class FilterTest_POM
    {
        public IWebDriver webDriver;
        public FilterTest_POM(IWebDriver driver)
        {
            webDriver = driver;
        }
        By fillterOption = By.XPath("//select[@class='product_sort_container']");



        public List<string> OptionResult()
        {
            var productElements = webDriver.FindElements(By.ClassName("inventory_item_name"));
            List<string> actualNames = productElements.Select(e => e.Text).ToList();
            return actualNames;
        }

        public void ClickAtoZ() 
        {
            //IWebElement dropdown = webDriver.FindElement(fillterOption);
            var select = new SelectElement(ManageDriver.driver.FindElement(By.ClassName("product_sort_container")));
            select.SelectByValue("az");
            //SelectElement select = new SelectElement(dropdown);
            //IWebElement element = CommonMethods.WaitAndFindElement(fillterOption);
            //select.SelectByValue("aZ");

            //CommonMethods.Highlightelement(select);
            //element.Click();
        }

        public void ClickZtoA()
        {
            IWebElement dropdown = webDriver.FindElement(fillterOption);

            SelectElement select = new SelectElement(dropdown);
            IWebElement element = CommonMethods.WaitAndFindElement(fillterOption);
            select.SelectByValue("aZ");

            CommonMethods.Highlightelement(element);
            element.Click();
        }

        public void ClickASC()
        {
            IWebElement dropdown = webDriver.FindElement(fillterOption);

            SelectElement select = new SelectElement(dropdown);
            IWebElement element = CommonMethods.WaitAndFindElement(fillterOption);
            select.SelectByValue("lohi");

            CommonMethods.Highlightelement(element);
            element.Click();
        }

        public void ClickDESC()
        {
            IWebElement dropdown = webDriver.FindElement(fillterOption);

            SelectElement select = new SelectElement(dropdown);
            IWebElement element = CommonMethods.WaitAndFindElement(fillterOption);
            select.SelectByValue("hilo");

            CommonMethods.Highlightelement(element);
            element.Click();
        }
    }
}
