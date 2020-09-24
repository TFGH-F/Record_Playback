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
public class TC02IngresarcdigodedepartamentorepetidoTest {
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
  public void tC02Ingresarcdigodedepartamentorepetido() {
    driver.Navigate().GoToUrl("http://25.76.110.243:8030/");
        driver.FindElement(By.LinkText("Department")).Click();
    driver.FindElement(By.LinkText("Save Department")).Click();
    driver.FindElement(By.Id("Code")).Click();
    driver.FindElement(By.Id("Code")).SendKeys("02");
    driver.FindElement(By.Id("Name")).Click();
    driver.FindElement(By.Id("Name")).SendKeys("Astronomia");
    driver.FindElement(By.CssSelector(".btn")).Click();
    Assert.That(driver.FindElement(By.CssSelector("form > p")).Text, Is.EqualTo("Saved Successfully"));
    driver.FindElement(By.LinkText("Department")).Click();
    driver.FindElement(By.LinkText("Save Department")).Click();
    driver.FindElement(By.Id("Code")).Click();
    driver.FindElement(By.Id("Code")).SendKeys("02");
    driver.FindElement(By.Id("Name")).Click();
    driver.FindElement(By.Id("Name")).SendKeys("Estudios");
    driver.FindElement(By.CssSelector(".btn")).Click();
    Assert.That(driver.FindElement(By.CssSelector("form > p")).Text, Is.EqualTo("Department Code Already Exists. Department Codebe be unique"));
    driver.FindElement(By.LinkText("Department")).Click();
    driver.FindElement(By.LinkText("View All Departments")).Click();
    driver.FindElement(By.LinkText("2")).Click();
    Assert.That(driver.FindElement(By.CssSelector(".grid-row:nth-child(3) > .grid-cell:nth-child(1)")).Text, Is.EqualTo("02"));
    Assert.That(driver.FindElement(By.CssSelector(".grid-row:nth-child(3) > .grid-cell:nth-child(2)")).Text, Is.EqualTo("Astronomia"));
    driver.Close();
  }
}
