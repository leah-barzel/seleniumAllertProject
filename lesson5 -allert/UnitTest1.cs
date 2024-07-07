using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;

namespace lesson5__allert
{
    public class Tests
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        string path = "T:\\הנדסת תוכנה\\שנה ב\\קבוצה ב\\תלמידות\\לאה ברזל\\אוטומציה שיעור 5\\.vs";
        public Tests() { }
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(path);

        }

        [Test]
        public void Test1()
        {
            //1
            driver.Navigate().GoToUrl("https://demoqa.com/alerts");
            string id = "timerAlertButton";
            IWebElement button = driver.FindElement(By.Id(id));
            button.Click();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.AlertIsPresent());

            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            Assert.Pass();
        }

        [Test]
        public void Test2() 
        {
           
            driver.Navigate().GoToUrl("https://demoqa.com/browser-windows");
            IWebElement windowsButton = driver.FindElement(By.Id("windowButton"));
            string currentButton = driver.CurrentWindowHandle.ToString();   
            windowsButton.Click(); 
            

        }

        [TearDown]
        public void TearDown() {
        driver.Dispose();
        }
        
    }
}