using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.PageObjects;
using Selenium.Utility;
using NUnit.Framework;
using Allure.NUnit.Attributes;
using Allure.Commons.Model;
using NUnit.Allure.Core;

namespace Selenium_2___Page_Object_Model
{
    [TestFixture(Author = "unickq", Description = "Examples")]
    [AllureNUnit]
    public class Test
    {
        IWebDriver driver;
        [Test]
     
        [AllureTag("NUnit", "Debug")]
        [AllureSeverity(SeverityLevel.Normal)]
        [AllureFeature("Core")]
        public void Test1()
        { 
            driver = new ChromeDriver();
            JSONReader jsReader = new JSONReader();
            ExtentReporting ext = new ExtentReporting();
            ext.setupExtentReport("Selenium TAF", "Selenium TAF");
            ext.createTest("Login Test");
            driver.Url = jsReader.jsonReader("../Selenium 2 - Page Object Model/Data/json1.json", "URL");
            BankLogin bnkl = new BankLogin(driver);
            bnkl.Login(jsReader.jsonReader("../Selenium 2 - Page Object Model/Data/json1.json", "User_Name"), jsReader.jsonReader("../Selenium 2 - Page Object Model/Data/json1.json", "password"));
            HomePage hm = new HomePage(driver);
            string bannerValue = hm.VerifyUserName();
            if (bannerValue == "Guru99 Bank")
            {
                ext.logReportStatement(AventStack.ExtentReports.Status.Pass, "Logged in success");

            }
            else
            {
                ext.logReportStatement(AventStack.ExtentReports.Status.Fail, "Logged in fail....");
            }
            Assert.AreEqual(bannerValue, "Guru99 Bank");
            ext.flushReport();
            driver.Close();     
            driver.Quit();

           
        }
    }
}
