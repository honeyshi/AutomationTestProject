using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Globalization;
using System.Threading;

namespace UnitTestProject
{
    public class Page
    {
        private readonly Repository repository;
        private readonly IWebDriver webDriver;

        public Page()
        {
            webDriver = new ChromeDriver();
            repository = new Repository();
        }

        #region Select Values
        public void SelectModelInTable(string modelName)
        {
            webDriver.FindElement(By.XPath(repository.ModelInTable(modelName))).Click();
            Thread.Sleep(1000);
        }

        public void InputDiscount(string discountAmount)
        {
            webDriver.FindElement(By.XPath(repository.DiscountInput)).SendKeys(discountAmount);
            Thread.Sleep(1000);
        }

        public void SelectSpecial(string specialName)
        {
            SelectElement specialsSelect = new SelectElement(webDriver.FindElement
                (By.XPath(repository.SpecialsDropDown)));
            specialsSelect.SelectByText(specialName);
            Thread.Sleep(1000);
        }

        public void SelectAccessory(string accessoryName)
        {
            webDriver.FindElement(By.XPath(repository.AccessoryCheckbox(accessoryName)));
            Thread.Sleep(1000);
        }

        public void SelectTab(string tabName)
        {
            webDriver.FindElement(By.XPath(repository.SelectTab(tabName))).Click();
            Thread.Sleep(1000);
        }

        public void DisableAddAccessoryPrice()
        {
            var checkbox = webDriver.FindElement(By.XPath(repository.AddAccessoryPriceCheckbox));
            if (checkbox.Selected)
            {
                checkbox.Click();
            }
            Thread.Sleep(1000);
        }

        public void ClickDiscountButton(int times)
        {
            for (int i = 0; i < times; i++)
            {
                webDriver.FindElement(By.XPath(repository.DiscountButton)).Click();
                Thread.Sleep(1000);
            }
        }

        public void SelectMenuBar(string menuBarName)
        {
            webDriver.FindElement(By.XPath(repository.SelectMenu(menuBarName))).Click();
            Thread.Sleep(1000);
        }

        public void SelectMenuSubItem(string menuSubItem)
        {
            webDriver.FindElement(By.XPath(repository.MenuSubitem(menuSubItem))).Click();
            Thread.Sleep(1000);
        }
        #endregion

        #region Getters
        public double GetFinalPrice()
        {
            NumberStyles styles = NumberStyles.AllowDecimalPoint;
            IFormatProvider provider = NumberFormatInfo.InvariantInfo;
            string finalPriceString = webDriver.FindElement(By.XPath(repository.FinalPrice)).Text;
            finalPriceString = finalPriceString.Replace(",", string.Empty);
            return Double.Parse(finalPriceString, styles, provider);
        }

        public double GetBasePrice()
        {
            NumberStyles styles = NumberStyles.AllowDecimalPoint;
            IFormatProvider provider = NumberFormatInfo.InvariantInfo;
            string basePriceString = webDriver.FindElement(By.XPath(repository.BasePrice)).Text;
            basePriceString = basePriceString.Replace(",", string.Empty);
            return Double.Parse(basePriceString, styles, provider);
        }

        public double GetSpecialPrice()
        {
            NumberStyles styles = NumberStyles.AllowDecimalPoint;
            IFormatProvider provider = NumberFormatInfo.InvariantInfo;
            string specialPriceString = webDriver.FindElement(By.XPath(repository.SpecialPrice)).Text;
            specialPriceString = specialPriceString.Replace(",", string.Empty);
            return Double.Parse(specialPriceString, styles, provider);
        }

        public double GetAccessoryPrice()
        {
            NumberStyles styles = NumberStyles.AllowDecimalPoint;
            IFormatProvider provider = NumberFormatInfo.InvariantInfo;
            string accessoryPriceString = webDriver.FindElement(By.XPath(repository.AccessoryPrice)).Text;
            accessoryPriceString = accessoryPriceString.Replace(",", string.Empty);
            return Double.Parse(accessoryPriceString, styles, provider);
        }
        #endregion

        public void OpenSite()
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl(@"file:///C:/Users/misso/source/repos/UnitTestProject/UnitTestProject/TestData/CarConfig.htm");
            
        }

        public void CloseSite()
        {
            webDriver.Close();
        }
    }
}
