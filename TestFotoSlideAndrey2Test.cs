// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class TestFotoSlideAndrey2Test {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void testFotoSlideAndrey2() {
    driver.Navigate().GoToUrl("https://mypollycoffee.tilda.ws");
    driver.Manage().Window.Size = new System.Drawing.Size(1082, 800);
    driver.FindElement(By.LinkText("Штат")).Click();
    driver.FindElement(By.Id("cardbtn2_664328264")).Click();
    driver.FindElement(By.CssSelector(".t-slds__arrow_body-left > svg")).Click();
    driver.FindElement(By.CssSelector(".t-slds__arrow_body-left > svg")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".t-slds__arrow_body-left > svg"));
      Actions builder = new Actions(driver);
      builder.DoubleClick(element).Perform();
    }
    driver.FindElement(By.CssSelector(".t-slds__arrow_body-left > svg")).Click();
    driver.FindElement(By.CssSelector(".t-slds__arrow_body-left > svg")).Click();
    driver.FindElement(By.CssSelector(".t-slds__arrow_body-left > svg")).Click();
    driver.FindElement(By.CssSelector(".t-slds__arrow_body-left > svg")).Click();
    driver.FindElement(By.CssSelector(".t-slds__arrow_body-left > svg")).Click();
    driver.FindElement(By.CssSelector(".t-slds__arrow_body-left > svg")).Click();
    driver.FindElement(By.CssSelector(".t-slds__arrow_body-left > svg")).Click();
  }
}