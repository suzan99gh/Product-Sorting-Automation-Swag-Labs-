using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SwagLabs.Helpers;

namespace SwagLabs.POM
{
    public class Login_POM
    {
        public IWebDriver webDriver;
        public Login_POM(IWebDriver driver) 
        {
            webDriver = driver; 
        }
        By loginUsername = By.XPath("//div/form/input[@id='user-name']");
        By loginPassword = By.XPath("//div/form/input[@id='password']");
        By loginBtn = By.XPath("//div/form/input[@id='login-button']");

        public void EnterUserName(string value)
        {
            IWebElement element = CommonMethods.WaitAndFindElement(loginUsername);

            CommonMethods.Highlightelement(element);
            element.SendKeys(value);
        }

        public void EnterPassword(string value)
        {
            IWebElement element = CommonMethods.WaitAndFindElement(loginPassword);

            CommonMethods.Highlightelement(element);
            element.SendKeys(value);
        }

        public void ClickLogin()
        {
            IWebElement element = CommonMethods.WaitAndFindElement(loginBtn);

            CommonMethods.Highlightelement(element);
            element.Click();
        }
    }
}
