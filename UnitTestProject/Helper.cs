using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    public class Helper
    {
        private readonly Page page;
        public Helper()
        {
            page = new Page();
        }

        public void OpenSite()
        {
            page.OpenSite();
        }

        public void CloseSite()
        {
            page.CloseSite();
        }

        public void SelectModelInTable(string modelName)
        {
            page.SelectModelInTable(modelName);
        }

        public void InputDiscount(string discountAmount)
        {
            page.InputDiscount(discountAmount);
        }

        public double GetFinalPrice()
        {
            return page.GetFinalPrice();
        }

        public double GetBasePrice()
        {
            return page.GetBasePrice();
        }

        public double GetSpecialPrice()
        {
            return page.GetSpecialPrice();
        }

        public double GetAccessoryPrice()
        {
            return page.GetAccessoryPrice();
        }

        public void ValidateFinalPrice(double expectedPrice)
        {
            double actualPrice = page.GetFinalPrice();
            Assert.AreEqual(expectedPrice, actualPrice, "Prices are not equal");
        }

        public void ValidateFinalPriceRecalculated(double initialPrice, int discount)
        {
            double actualPrice = page.GetFinalPrice();
            double expectedPrice = initialPrice - (initialPrice * discount / 100);
            Assert.AreEqual(expectedPrice, actualPrice, "Prices are not equal");
        }

        public void SelectSpecial(string specialName)
        {
            page.SelectSpecial(specialName);
        }

        public void SelectAccessory(string accessoryName)
        {
            page.SelectAccessory(accessoryName);
        }

        public void SelectTab(string tabName)
        {
            page.SelectTab(tabName);
        }

        public void DisableAddAccessoryPrice()
        {
            page.DisableAddAccessoryPrice();
        }

        public void ClickDicountButton(int times)
        {
            page.ClickDiscountButton(times);
        }

        public void SelectMenuBar(string menuBarName)
        {
            page.SelectMenuBar(menuBarName);
        }

        public void SelectMenuSubItem(string menuSubItem)
        {
            page.SelectMenuSubItem(menuSubItem);
        }
    }
}
