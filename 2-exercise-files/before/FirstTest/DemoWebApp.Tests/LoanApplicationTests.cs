using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoWebApp.Tests
{
    class LoanApplicationTests
    {
        [Fact]
        public void StartApplication()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
    }
}
