using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwagLabs.Helpers;
using SwagLabs.POM;

namespace Efwatercom.AssistantMethods
{
    public class Login_AssistantMethods
    {

        public static void UserLogin()
        {

           Login_POM login_POM = new Login_POM(ManageDriver.driver);
            login_POM.EnterUserName("standard_user");
            login_POM.EnterPassword("secret_sauce");
            login_POM.ClickLogin();
            
        }
    }
}
