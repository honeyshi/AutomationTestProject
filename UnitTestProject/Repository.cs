namespace UnitTestProject
{
    public class Repository
    {
        public string ModelInTable(string modelName) =>
            $".//div[contains(@id, 'VehicleTable')]//tr//td[contains(text(), '{modelName}')]";

        #region Tabs
        public string Tabs => ".//ul[@id='Tabs']";
        public string SelectTab(string tabName) => $"{Tabs}//a[contains(text(), '{tabName}')]";
        #endregion

        #region Menu
        public string Menu => ".//ul[@id='MenuBar']";
        public string SelectMenu(string menuName) => $"{Menu}//a[contains(text(), '{menuName}')]";
        public string MenuSubitem(string subItemName) =>
            $"{Menu}//li[@class='menusubitem']//a[contains(text(), '{subItemName}')]";
        #endregion


        #region Calculator Panel
        public string CalculatorPanel => ".//table[@id='CalculatorPanel']";
        public string DiscountInput => $"{CalculatorPanel}//input[contains(@id, 'DiscountValue')]";
        public string FinalPrice => $"{CalculatorPanel}//span[contains(@id, 'CalculatedPrice')]";
        public string BasePrice => $"{CalculatorPanel}//span[contains(@id, 'BasePrice')]";
        public string SpecialPrice => $"{CalculatorPanel}//span[contains(@id, 'SpecialPrice')]";
        public string AccessoryPrice => $"{CalculatorPanel}//span[contains(@id, 'AccessoryPrice')]";
        public string DiscountButton => $"{CalculatorPanel}//div[@class='button']";
        #endregion

        #region Specials Panel
        public string SpecialsPanel => ".//div[@id='SpecialsPanel']";
        public string SpecialsDropDown => $"{SpecialsPanel}//select[@id='SpecialsCombo']";
        #endregion

        #region Accessories
        public string AccessoriesPanel => ".//div[@id='AccessoryTablePanel']";
        public string AccessoryCheckbox(string accessoryName) =>
            $"{AccessoriesPanel}//tr//td[contains(text(), '{accessoryName}')]//preceding-sibling::td//input";
        public string AddAccessoryPriceCheckbox =>
            $"{AccessoriesPanel}//input[contains(@id, 'AddAccessoryPrice')]";
        #endregion
    }
}
