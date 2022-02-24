using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class test1
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\ASUS\source\repos\Selenium_test\bin\Debug");
         
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";


           IWebDriver driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("email_create")).Click();
            driver.FindElement(By.Id("email_create")).Clear();
            driver.FindElement(By.Id("email_create")).SendKeys("1234gg5@gmail.com");
            driver.FindElement(By.XPath("//button[@id='SubmitCreate']/span")).Click();
            driver.FindElement(By.Id("id_gender1")).Click();
            driver.FindElement(By.Id("customer_firstname")).Click();
            driver.FindElement(By.Id("customer_firstname")).Clear();
            driver.FindElement(By.Id("customer_firstname")).SendKeys("John");
            driver.FindElement(By.Id("customer_lastname")).Click();
            driver.FindElement(By.Id("customer_lastname")).Clear();
            driver.FindElement(By.Id("customer_lastname")).SendKeys("Parker");
            driver.FindElement(By.Id("passwd")).Click();
            driver.FindElement(By.Id("passwd")).Clear();
            driver.FindElement(By.Id("passwd")).SendKeys("12345678");
            driver.FindElement(By.Id("address1")).Click();
            driver.FindElement(By.Id("address1")).Clear();
            driver.FindElement(By.Id("address1")).SendKeys("Dhaka");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("Dhaka");
            driver.FindElement(By.Id("id_state")).Click();
            new SelectElement(driver.FindElement(By.Id("id_state"))).SelectByText("Alabama");
            driver.FindElement(By.XPath("//select[@id='id_state']/option[2]")).Click();
            driver.FindElement(By.Id("postcode")).Click();
            driver.FindElement(By.Id("postcode")).Clear();
            driver.FindElement(By.Id("postcode")).SendKeys("12345");
            driver.FindElement(By.Id("phone_mobile")).Click();
            driver.FindElement(By.Id("phone_mobile")).Clear();
            driver.FindElement(By.Id("phone_mobile")).SendKeys("01711111111");
            driver.FindElement(By.Id("alias")).Click();
            driver.FindElement(By.Id("alias")).Clear();
            driver.FindElement(By.Id("alias")).SendKeys("My address1");
            driver.FindElement(By.XPath("//button[@id='submitAccount']/span")).Click();
            driver.FindElement(By.LinkText("Sign out")).Click();
            driver.FindElement(By.Id("email_create")).Click();
            driver.FindElement(By.Id("email_create")).Clear();
            driver.FindElement(By.Id("email_create")).SendKeys("1234gg6@gmail.com");
            driver.FindElement(By.XPath("//button[@id='SubmitCreate']/span")).Click();
            driver.FindElement(By.XPath("//form[@id='account-creation_form']/div/div/div/label")).Click();
            driver.FindElement(By.Id("customer_firstname")).Click();
            driver.FindElement(By.Id("customer_firstname")).Clear();
            driver.FindElement(By.Id("customer_firstname")).SendKeys("John");
            driver.FindElement(By.Id("customer_lastname")).Click();
            driver.FindElement(By.Id("customer_lastname")).Clear();
            driver.FindElement(By.Id("customer_lastname")).SendKeys("Parker");
            driver.FindElement(By.Id("passwd")).Click();
            driver.FindElement(By.Id("passwd")).Clear();
            driver.FindElement(By.Id("passwd")).SendKeys("12345678");
            driver.FindElement(By.Id("address1")).Click();
            driver.FindElement(By.Id("address1")).Clear();
            driver.FindElement(By.Id("address1")).SendKeys("Dhaka");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("Dhaka");
            driver.FindElement(By.Id("id_state")).Click();
            new SelectElement(driver.FindElement(By.Id("id_state"))).SelectByText("Connecticut");
            driver.FindElement(By.XPath("//select[@id='id_state']/option[8]")).Click();
            driver.FindElement(By.Id("postcode")).Click();
            driver.FindElement(By.Id("postcode")).Clear();
            driver.FindElement(By.Id("postcode")).SendKeys("12345");
            driver.FindElement(By.Id("phone_mobile")).Click();
            driver.FindElement(By.Id("phone_mobile")).Clear();
            driver.FindElement(By.Id("phone_mobile")).SendKeys("01711111111");
            driver.FindElement(By.Id("alias")).Click();
            driver.FindElement(By.Id("alias")).Clear();
            driver.FindElement(By.Id("alias")).SendKeys("My address2");
            driver.FindElement(By.XPath("//button[@id='submitAccount']/span")).Click();
            driver.FindElement(By.LinkText("Sign out")).Click();
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("1234gg3@gmail.com");
            driver.FindElement(By.Id("passwd")).Clear();
            driver.FindElement(By.Id("passwd")).SendKeys("12345678");
            driver.FindElement(By.XPath("//button[@id='SubmitLogin']/span/i")).Click();
            driver.FindElement(By.XPath("//div[@id='block_top_menu']/ul/li[2]/ul/li/a")).Click();
            driver.FindElement(By.XPath("//div[@id='center_column']/ul/li/div/div[2]/div[2]/a/span")).Click();
            driver.FindElement(By.XPath("//div[@id='layer_cart']/div/div[2]/div[4]/span/span")).Click();
            driver.FindElement(By.XPath("//div[@id='block_top_menu']/ul/li[3]/a")).Click();
            driver.FindElement(By.Id("layered_id_attribute_group_14")).Click();
            driver.FindElement(By.Id("color_2")).Click();
            driver.FindElement(By.XPath("//p[@id='add_to_cart']/button/span")).Click();
            driver.FindElement(By.XPath("//div[@id='layer_cart']/div/div[2]/div[4]/a/span")).Click();
            driver.FindElement(By.XPath("//div[@id='center_column']/p[2]/a/span")).Click();
            driver.FindElement(By.XPath("//div[@id='center_column']/form/p/button/span")).Click();
            driver.FindElement(By.Id("cgv")).Click();
            driver.FindElement(By.XPath("//form[@id='form']/p/button/span")).Click();
            driver.FindElement(By.XPath("//div[@id='HOOK_PAYMENT']/div[2]/div/p/a/span")).Click();
            driver.FindElement(By.XPath("//p[@id='cart_navigation']/button/span")).Click();
            driver.FindElement(By.LinkText("Sign out")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
