using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestAutomation.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Open()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://staging-finance.rabbitinternet.com/en/product/health-insurance/questions";
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
