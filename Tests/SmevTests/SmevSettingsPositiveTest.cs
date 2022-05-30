using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestShluz1.Tests
{
    internal class SmevSettingsPositiveTest: BaseTest

    {
        [SetUp]
        //делаем метод для тестирования
        public void baseAuthorisation()
        {
            //driver.Navigate().GoToUrl(urlSmev);
            //driver.FindElement(_Auth).Click();
            driver.FindElement(_userName).SendKeys(userName);
            driver.FindElement(_password).SendKeys(userPassword);
            driver.FindElement(_enterLocator).Click();
            driver.Navigate().GoToUrl(urlSmev);
            driver.FindElement(_Auth).Click();
            driver.FindElement(_userName).SendKeys(userName);
            driver.FindElement(_password).SendKeys(userPassword);
            driver.FindElement(_enterLocator).Click();
        }



        [Test]
        //делаем метод для тестирования
        public void SmevSettingTest()
        {

        driver.FindElement(_smevSettingsField).Click();
        driver.FindElement(_smevConfigField).Click();
        driver.Navigate().Back();
        driver.FindElement(_smevSignservicesField).Click();
        driver.Navigate().Back();
        driver.FindElement(_smevEndpointsField).Click();
        driver.Navigate().Back();
        driver.FindElement(_smevAdaptersField).Click();
        driver.Navigate().Back();
        driver.FindElement(_smevVsField).Click();
        driver.Navigate().Back();
        driver.FindElement(_smevTemplatesField).Click();
        driver.Navigate().Back();
        driver.FindElement(_smevDictsField).Click();
        driver.Navigate().Back();
        driver.FindElement(_smevThumbsField).Click();
        driver.Navigate().Back();
        }

    }
}
