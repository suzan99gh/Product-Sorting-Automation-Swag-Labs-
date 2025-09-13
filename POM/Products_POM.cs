using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using SwagLabs.Helpers;
using OpenQA.Selenium.DevTools.V137.DOM;
using OpenQA.Selenium.Support.UI;

namespace SwagLabs.POM
{
    public class Products_POM
    {
        public IWebDriver webDriver;
        public Products_POM(IWebDriver driver)
        {
            webDriver = driver; 
        }
        By productCard = By.XPath("(//div[@class='inventory_item'])");
        By addToCartBtn = By.XPath("//button[@class='btn_primary btn_inventory']");
        By cartNum = By.XPath("//a/span[@class='fa-layers-counter shopping_cart_badge']");

        public void ClickRandomProduct()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));

            IList<IWebElement> products = wait.Until(d =>
            {
                var elems = d.FindElements(addToCartBtn);
                return elems.Count > 0 ? elems : null;
            });

            int numberOfItems = products.Count;
            Console.WriteLine($"Number of products found: {numberOfItems}");

            Random rand = new Random();
            int randomIndex = rand.Next(0, numberOfItems);
            Console.WriteLine($"Clicked random item at index: {randomIndex}");

            IWebElement chosenProduct = products[randomIndex];
            chosenProduct.Click();
            CommonMethods.Highlightelement(chosenProduct);
        }



        public void ScrollUp ()
        { 
            Thread.Sleep(1000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
            js.ExecuteScript("window.scrollTo(0, 0);");
        }
        public string CheckCartNumber()
        {
           
            IWebElement number = CommonMethods.WaitAndFindElement(cartNum);
            string value = number.Text;
            Console.WriteLine(value);
            return(value);
        }
    }
}
