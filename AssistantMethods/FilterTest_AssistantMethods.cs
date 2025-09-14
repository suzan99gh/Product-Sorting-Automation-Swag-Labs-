using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swag_Labs_Filters.POM;
using SwagLabs.Helpers;
using SwagLabs.POM;

namespace Swag_Labs_Filters.AssistantMethods
{
    public class FilterTest_AssistantMethods
    {
        public static void AtoZoption()
        {
            FilterTest_POM filterTest = new FilterTest_POM(ManageDriver.driver);
            filterTest.ClickAtoZ();
        }

        public static void ZtoAoption()
        {
            FilterTest_POM filterTest = new FilterTest_POM(ManageDriver.driver);
            filterTest.ClickZtoA();
        }

        public static void ASCoption()
        {
            FilterTest_POM filterTest = new FilterTest_POM(ManageDriver.driver);
            filterTest.ClickASC();
        }

        public static void DESCoption()
        {
            FilterTest_POM filterTest = new FilterTest_POM(ManageDriver.driver);
            filterTest.ClickDESC();
        }
    }
}
