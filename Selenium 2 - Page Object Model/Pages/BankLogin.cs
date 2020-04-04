using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace Selenium.PageObjects
{
    class BankLogin
    {

        private IWebDriver _driver;

        private readonly By _userName = By.Name("uid");
        private readonly By _password = By.Name("password");
        private readonly By _btnLogin = By.Name("btnLogin");
        
        public BankLogin(IWebDriver driver)
        {
            this._driver = driver;
        }
        public void Login(string userName, string password)
        {
            _driver.FindElement(_userName).SendKeys(userName);
            _driver.FindElement(_password).SendKeys(password);
            _driver.FindElement(_btnLogin).Click();
        }
    }
}
