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
public class TestSendSayavkaWithWrongEmailTest {
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
  public void testSendSayavkaWithWrongEmail() {
    driver.Navigate().GoToUrl("https://mypollycoffee.tilda.ws");
    driver.Manage().Window.Size = new System.Drawing.Size(1086, 800);
    driver.FindElement(By.CssSelector(".t-btn td")).Click();
    driver.FindElement(By.Id("input_1518534410690")).Click();
    driver.FindElement(By.Id("input_1518534410690")).SendKeys("dfghjk");
    driver.FindElement(By.Id("input_1518534405414")).Click();
    driver.FindElement(By.Id("input_1518534405414")).SendKeys("dsfghjkl;");
    driver.FindElement(By.Id("input_1518534421664")).Click();
    driver.FindElement(By.Id("input_1518534421664")).SendKeys("dsghjl");
    driver.FindElement(By.CssSelector(".t-form__submit:nth-child(5) > .t-submit")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".t-form__submit:nth-child(5) > .t-submit"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.TagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.CssSelector(".t-form__errorbox-middle:nth-child(4) .t-form__errorbox-text")).Click();
  }
}
