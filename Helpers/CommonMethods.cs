using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Efwatercom.Data;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace SwagLabs.Helpers
{
    public class CommonMethods
    {
        public static void NavigateToURL(string url)
        {
            ManageDriver.driver.Navigate().GoToUrl(url);
        }
        public static void Highlightelement(IWebElement element)
        {
            IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor)ManageDriver.driver;
            javaScriptExecutor.ExecuteScript("arguments[0].setAttribute('style', 'background: yellow !important')", element);
            Thread.Sleep(1000);
            javaScriptExecutor.ExecuteScript("arguments[0].setAttribute('style', 'background: none !important')", element);
        }


        public static string TakeScreenShot()
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)ManageDriver.driver;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            string path = "C:\\Users\\moalgharX\\source\\repos\\SwagLabs\\Data\\Images\\";
            string imageName = Guid.NewGuid().ToString() + "_image.png"; 
            string fullPath = Path.Combine(path + $"\\{imageName}");
            screenshot.SaveAsFile(fullPath);
            return fullPath;
        }



        public static IWebElement WaitAndFindElement(By by)//By.XPath("//div/input[@id='Fname']");
        {
            var waiting = new DefaultWait<IWebDriver>(ManageDriver.driver)
            {
                Timeout = TimeSpan.FromSeconds(10),
                PollingInterval = TimeSpan.FromMilliseconds(500),
            };
            waiting.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement element = waiting.Until(x => x.FindElement(by));
            return element;
        }
    }
}
