using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Swag_Labs_Filters.POM
{
    public class HomePage_POM
    {
        public IWebDriver webDriver;
        public HomePage_POM(IWebDriver driver)
        {
            webDriver = driver;
        }
        By fillterOption = By.XPath("//span[@class='active_option']");
    }
}
