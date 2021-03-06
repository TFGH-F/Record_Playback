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
public class TC09AadirnotasalestudianteTest {
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
  public void tC09Aadirnotasalestudiante() {
    driver.Navigate().GoToUrl("http://25.76.110.243:8030/");
        driver.FindElement(By.LinkText("Student")).Click();
        driver.FindElement(By.LinkText("Save Student Result")).Click();
        driver.FindElement(By.CssSelector(".btn")).Click();
        Assert.That(driver.FindElement(By.Id("StudentId-error")).Text, Is.EqualTo("Please select the student reg no"));
        Assert.That(driver.FindElement(By.Id("CourseId-error")).Text, Is.EqualTo("Please select a course"));
        Assert.That(driver.FindElement(By.Id("Grade-error")).Text, Is.EqualTo("Please select grade"));
        driver.FindElement(By.Id("StudentId")).Click();
        {
            var dropdown = driver.FindElement(By.Id("StudentId"));
            dropdown.FindElement(By.XPath("//option[. = '16-1997-001']")).Click();
        }
        driver.FindElement(By.Id("StudentId")).Click();
        driver.FindElement(By.Id("CourseId")).Click();
        {
            var dropdown = driver.FindElement(By.Id("CourseId"));
            dropdown.FindElement(By.XPath("//option[. = 'Natación']")).Click();
        }
        driver.FindElement(By.Id("CourseId")).Click();
        driver.FindElement(By.Id("Grade")).Click();
        {
            var dropdown = driver.FindElement(By.Id("Grade"));
            dropdown.FindElement(By.XPath("//option[. = 'A+']")).Click();
        }
        driver.FindElement(By.Id("Grade")).Click();
        {
            string value = driver.FindElement(By.Id("Name")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("Martha Rodriguez"));
        }
        {
            string value = driver.FindElement(By.Id("Email")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("maro@gmail.com"));
        }
        {
            string value = driver.FindElement(By.Id("Department")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("Deporte"));
        }
        {
            var element = driver.FindElement(By.Id("Name"));
            Boolean isEditable = element.Enabled && element.GetAttribute("readonly") == null;
            Assert.False(isEditable);
        }
        {
            var element = driver.FindElement(By.Id("Email"));
            Boolean isEditable = element.Enabled && element.GetAttribute("readonly") == null;
            Assert.False(isEditable);
        }
        {
            var element = driver.FindElement(By.Id("Department"));
            Boolean isEditable = element.Enabled && element.GetAttribute("readonly") == null;
            Assert.False(isEditable);
        }
        driver.FindElement(By.CssSelector(".btn")).Click();
        Assert.That(driver.FindElement(By.CssSelector("#saveStudentResult > p")).Text, Is.EqualTo("Saved sucessfull!"));
        driver.Close();
  }
}
