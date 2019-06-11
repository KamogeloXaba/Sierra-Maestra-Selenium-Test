using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Sierra_Maestra_Tests
{
    [TestClass]
    public class SierraMaestraTests
    {

        [TestMethod]
        public void HomePageTitleContainsSierraMaestra()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Navigate().GoToUrl("https://sierramaestra.co.za/");
            }

            catch (Exception ex)
            {
                Thread.Sleep(5000);
            }

            driver.Manage().Window.Maximize();

            Assert.IsTrue(driver.Title.Contains("Sierra Maestra"));

            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void HomePageContainsAnchorSM()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://sierramaestra.co.za");
            driver.Manage().Window.Maximize();
            var smAnchor = driver.FindElement(By.XPath("//*[@id='gtco-logo']/a"));
            Assert.IsTrue(smAnchor.Text.Contains("SM"));
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void HomePageContainsTestimonial()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://sierramaestra.co.za");
            driver.Manage().Window.Maximize();
            var divTestimonial = driver.FindElement(By.Id("gtco-testimonial"));
            Assert.IsNotNull(divTestimonial);
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void HomePageContainsSubscribePanel()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://sierramaestra.co.za");
            driver.Manage().Window.Maximize();
            var divSubscribe = driver.FindElement(By.Id("gtco-subscribe"));
            Assert.IsNotNull(divSubscribe);
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void HomePageContainsCopyRight()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://sierramaestra.co.za");
            driver.Manage().Window.Maximize();
            var divCopyright = driver.FindElement(By.ClassName("block"));
            Assert.IsNotNull(divCopyright);
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void HomePageContainsSocialMediaLogos()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://sierramaestra.co.za");
            driver.Manage().Window.Maximize();
            var ulIcons = driver.FindElement(By.XPath("//*[@id='gtco-footer']/div/div[2]/div/ul"));
            Assert.IsNotNull(ulIcons);
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void AboutPageContainsTitleAboutUs()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://sierramaestra.co.za");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@id='page']/nav/div/div/div[2]/ul/li[2]/a")).Click();
            var divAboutPage = driver.FindElement(By.XPath("//*[@id='gtco-header']/div[2]/div/div/div/div"));
            Assert.IsTrue(divAboutPage.Text.Contains("ABOUT US"));
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void AboutPageContainsFounderOfCompany()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://sierramaestra.co.za");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@id='page']/nav/div/div/div[2]/ul/li[2]/a")).Click();
            var divFounder = driver.FindElement(By.ClassName("gtco-container"));
            Assert.IsNotNull(divFounder);
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void AboutPageContainsFoundersDescription()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://sierramaestra.co.za");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@id='page']/nav/div/div/div[2]/ul/li[2]/a")).Click();
            var divDescription = driver.FindElement(By.XPath("//*[@id='gtco-team']/div/div[2]/div/div/div"));
            Assert.IsNotNull(divDescription);
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void AboutPageContainsSocialMediaLogos()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://sierramaestra.co.za");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@id='page']/nav/div/div/div[2]/ul/li[2]/a")).Click();
            var ulLogo = driver.FindElement(By.ClassName("gtco-social-icons"));
            Assert.IsNotNull(ulLogo);
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void ServicesPageContainsTitle()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://sierramaestra.co.za");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@id='page']/nav/div/div/div[2]/ul/li[3]/a")).Click();
            var divTitle = driver.FindElement(By.XPath("//*[@id='gtco-header']/div[2]/div/div/div/div"));
            Assert.IsTrue(divTitle.Text.Contains("OUR SERVICES"));
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void ServicesPageContainsWhatWeOffer()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://sierramaestra.co.za");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@id='page']/nav/div/div/div[2]/ul/li[3]/a")).Click();
            var divWhatWeOffer = driver.FindElement(By.XPath("//*[@id='gtco-services']/div/div[1]/div"));
            Assert.IsTrue(divWhatWeOffer.Text.Contains("What We Offer"));
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void ServicesPageContainsAPictureInEachElement()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://sierramaestra.co.za");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@id='page']/nav/div/div/div[2]/ul/li[3]/a")).Click();
            driver.FindElement(By.ClassName("hidden-xs")).Click();
            var imgMarketAnalysis = driver.FindElement(By.XPath("//*[@id='gtco-services']/div/div[2]/div/div/div[1]/div[2]/figure/img"));
            Assert.IsNotNull(imgMarketAnalysis);
            driver.FindElement(By.XPath("//*[@id='gtco-services']/div/div[2]/div/ul/li[2]/a/span[2]")).Click();
            var imgCompetitorAnalysis = driver.FindElement(By.XPath("//*[@id='gtco-services']/div/div[2]/div/div/div[2]/div[2]/figure/img"));
            Assert.IsNotNull(imgCompetitorAnalysis);
            driver.FindElement(By.XPath("//*[@id='gtco-services']/div/div[2]/div/ul/li[3]/a/span[2]")).Click();
            var imgCustomerAnalysis = driver.FindElement(By.XPath("//*[@id='gtco-services']/div/div[2]/div/div/div[3]/div[2]/figure/img"));
            Assert.IsNotNull(imgCustomerAnalysis);
            driver.FindElement(By.XPath("//*[@id='gtco-services']/div/div[2]/div/ul/li[4]/a/span[2]")).Click();
            var imgBrandEquityAnalysis = driver.FindElement(By.XPath("//*[@id='gtco-services']/div/div[2]/div/div/div[4]/div[2]/figure/img"));
            Assert.IsNotNull(imgBrandEquityAnalysis);
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void ContactPageContainsTitleGetInTouch()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://sierramaestra.co.za");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@id='page']/nav/div/div/div[2]/ul/li[4]/a")).Click();
            var divGetInTouch = driver.FindElement(By.XPath("//*[@id='gtco-header']/div[2]/div/div/div/div"));
            Assert.IsTrue(divGetInTouch.Text.Contains("GET IN TOUCH"));
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void ContactPageContainsAddress()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://sierramaestra.co.za");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@id='page']/nav/div/div/div[2]/ul/li[4]/a")).Click();
            var liAddress = driver.FindElement(By.ClassName("address"));
            Assert.IsNotNull(liAddress);
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void ContactPageContainsContactDetailsUnderTheAddress()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://sierramaestra.co.za");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@id='page']/nav/div/div/div[2]/ul/li[4]/a")).Click();
            var liContactDetails = driver.FindElement(By.ClassName("phone"));
            Assert.IsNotNull(liContactDetails);
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void ContactPageContainsEmailSAddress()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://sierramaestra.co.za");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@id='page']/nav/div/div/div[2]/ul/li[4]/a")).Click();
            var liEmailAddress = driver.FindElement(By.ClassName("email"));
            Assert.IsNotNull(liEmailAddress);
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void ContactPageContainsGetInTouch()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://sierramaestra.co.za");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@id='page']/nav/div/div/div[2]/ul/li[4]/a")).Click();
            var divContactPanel = driver.FindElement(By.XPath("//*[@id='page']/div[2]/div/div/div[1]"));
            Assert.IsNotNull(divContactPanel);
            driver.FindElement(By.Name("first_name")).SendKeys("Kamogelo");
            driver.FindElement(By.Name("last_name")).SendKeys("Xaba");
            driver.FindElement(By.Name("email")).SendKeys("kamogelotxaba@gmail.com");
            driver.FindElement(By.Name("subject")).SendKeys("Automation test using Selenium");
            driver.FindElement(By.Name("telephone")).SendKeys("084 455 4105");
            driver.FindElement(By.Name("message")).SendKeys("Selenium Webdriver");
            driver.FindElement(By.Name("submit")).Click();
            Thread.Sleep(8000);
            driver.Close();
            driver.Quit();
        }

    }

}
