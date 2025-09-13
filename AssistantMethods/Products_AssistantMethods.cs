using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwagLabs.Helpers;
using SwagLabs.POM;

namespace SwagLabs.AssistantMethods
{
    public class Products_AssistantMethods
    {
        public static void AddToCart()
        {
            Products_POM products_POM = new Products_POM(ManageDriver.driver);
            products_POM.ClickRandomProduct();
             Thread.Sleep(2000);
            products_POM.ClickRandomProduct();

        }
    }
}
