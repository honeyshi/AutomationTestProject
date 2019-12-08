using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        private readonly Helper helper = new Helper();

        [TestMethod]
        public void TestMethod1()
        {
            helper.OpenSite();
            helper.SelectModelInTable("Rolo");
            double initialPrice = helper.GetFinalPrice();
            helper.InputDiscount("10");
            helper.ValidateFinalPriceRecalculated(initialPrice, 10);
            helper.CloseSite();
        }

        [TestMethod]
        public void TestMethod2()
        {
            helper.OpenSite();
            helper.SelectTab("Vehicles");
            helper.SelectModelInTable("Rolo");
            helper.SelectTab("Specials");
            helper.SelectSpecial("Gomera");
            helper.SelectTab("Accessories");
            helper.SelectAccessory("Anti-skid system");
            double basePrice = helper.GetBasePrice();
            double specialPrice = helper.GetSpecialPrice();
            double accessoryPrice = helper.GetAccessoryPrice();
            helper.ValidateFinalPrice(basePrice + specialPrice + accessoryPrice);
            helper.CloseSite();
        }

        [TestMethod]
        public void TestMethod3()
        {
            helper.OpenSite();
            helper.SelectTab("Vehicles");
            helper.SelectModelInTable("Rolo");
            helper.SelectTab("Specials");
            helper.SelectSpecial("Gomera");
            helper.SelectTab("Accessories");
            helper.SelectAccessory("Anti-skid system");
            helper.DisableAddAccessoryPrice();
            double basePrice = helper.GetBasePrice();
            double specialPrice = helper.GetSpecialPrice();
            helper.ValidateFinalPrice(basePrice + specialPrice);
            helper.CloseSite();
        }

        [TestMethod]
        public void TestMethod4()
        {
            helper.OpenSite();
            helper.SelectTab("Vehicles");
            helper.SelectModelInTable("Rolo");
            double initialPrice = helper.GetFinalPrice();
            helper.ClickDicountButton(3);
            helper.ValidateFinalPriceRecalculated(initialPrice, 15);
            helper.CloseSite();
        }

        [TestMethod]
        public void TestMethod5()
        {
            helper.OpenSite();
            helper.SelectTab("Vehicles");
            helper.SelectModelInTable("Rolo");
            helper.SelectTab("Specials");
            helper.SelectSpecial("Gomera");
            helper.SelectTab("Accessories");
            helper.SelectAccessory("Anti-skid system");
            helper.SelectMenuBar("File");
            helper.SelectMenuSubItem("Reset");
            helper.ValidateFinalPrice(0.0);
            helper.CloseSite();
        }
    }
}
