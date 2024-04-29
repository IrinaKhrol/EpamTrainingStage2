using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver
{
    public class SearchResultPage : BasePage
    {
        protected By PricingCalculator = By.CssSelector("a.gs-title[href*='cloud.google.com/products/calculator']");

        public void ClickPricingCalculatorLink()
        {
            ClickElement(PricingCalculator);
        }

        public SearchResultPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
