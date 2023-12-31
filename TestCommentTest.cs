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
public class TestCommentTest {
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
  public void testComment() {
    driver.Navigate().GoToUrl("https://mypollycoffee.tilda.ws");
    driver.Manage().Window.Size = new System.Drawing.Size(1058, 800);
    driver.FindElement(By.CssSelector(".t-btn td")).Click();
    driver.FindElement(By.CssSelector(".t-form__submit:nth-child(6) > .t-submit")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".t-form__submit:nth-child(6) > .t-submit"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.TagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
  }
}
