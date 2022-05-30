using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestShluz1.Main
{
    public class BrowserShluz
    {
        public IWebDriver driver = null!;
        public readonly string urlLogin = "http://10.10.10.55:5000/login";
        public readonly string urlFeed = "http://10.10.10.55:5000/feed";
        public readonly string urlDashboard = "http://10.10.10.55:5000/admin/dashboard";
        public readonly string urlSmev = "http://10.10.10.55:5000/smev";

        //указываем логин и пароль? лучше вынести в другое место эти данные
        public readonly string userName = "superadmin";
        public readonly string userPassword = "2128506";
        //пишем как найти все элементы на странице, но почему мы повторяем это в pageObjectLogin?
        public readonly By _Auth = By.XPath("//a[@href='http://10.10.10.55:5000/login?return=%2Fsmev']");
        public readonly By _userName = By.XPath("//input[@placeholder='Логин']");
        public readonly By _password = By.XPath("//input[@placeholder='Пароль']");
        public readonly By _enterLocator = By.XPath("//button[@type='submit']");
        public readonly By _userNameLocator = By.XPath("//a[@href='/account']");
        public readonly By _adminLocator = By.XPath("//a[@href='/admin']");
        //settings

        public readonly By _smevSettingsField = By.XPath("/html/body/div[1]/div/div[1]/nav/div/div[2]/ul[1]/li[1]/a");
        public readonly By _smevConfigField = By.XPath("//a[@href ='/smev/settings/config']");
        public readonly By _smevSignservicesField = By.XPath("//a[@href ='/smev/settings/signservices']");
        public readonly By _smevEndpointsField = By.XPath("//a[@href ='/smev/settings/endpoints']");
        public readonly By _smevAdaptersField = By.XPath("//a[@href ='/smev/settings/']");
        public readonly By _smevVsField = By.XPath("//a[@href ='/smev/settings/ns']");
        public readonly By _smevTemplatesField = By.XPath("//a[@href ='/smev/settings/templates']");
        public readonly By _smevDictsField = By.XPath("//a[@href ='/smev/settings/dicts']");
        public readonly By _smevThumbsField = By.XPath("//a[@href ='/smev/settings/thumbs']");




        public bool ChekText => driver.PageSource.Contains("Неправильный логин или пароль!");


        [SetUp]
        public void startBrowser()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("--window-size=500,500");
            driver = new ChromeDriver();
            driver.Manage().Window.Size = new System.Drawing.Size(200, 100);
            driver.Url = urlLogin;
            driver.Manage().Window.Maximize();

        }
        /*[TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }*/
    }
}
