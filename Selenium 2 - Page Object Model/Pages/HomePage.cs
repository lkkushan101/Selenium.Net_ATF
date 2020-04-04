using OpenQA.Selenium;
namespace Selenium.PageObjects
{
   
        class HomePage
        {
            private IWebDriver _driver;
            private readonly By _banner = By.XPath("/html/body/div[2]/h2");

            public HomePage(IWebDriver driver)
            {
                this._driver = driver;
            }
            public string VerifyUserName()
            {
                return _driver.FindElement(_banner).Text;
            }

        }
  
}
