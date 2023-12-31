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
public class TestFromPolinaToAndreyTest {
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
  public void testFromPolinaToAndrey() {
    driver.Navigate().GoToUrl("https://mypollycoffee.tilda.ws");
    driver.Manage().Window.Size = new System.Drawing.Size(1110, 800);
    driver.FindElement(By.LinkText("Штат")).Click();
    driver.FindElement(By.Id("cardbtn3_664328264")).Click();
    js.ExecuteScript("window.scrollTo(0,1700)");
    driver.FindElement(By.LinkText("К Андрею")).Click();
  }
}
