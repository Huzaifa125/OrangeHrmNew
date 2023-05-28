using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrmAutomationMsTest
{
    public class BasePage
    {

        public static IWebDriver driver;

        public static string dirpath = "C:\\ExtentReports\\" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "\\";

        public IWebDriver ChromeOpen()
        {

            driver = new ChromeDriver();

            MaximizeWindow();

            return driver;
        }



        //public IWebDriver EdgeOpen()
        //{
        //    driver = new EdgeDriver();

        //    MaximizeWindow();

        //    return driver;

        //}

        //public IWebDriver FirefoxOpen()
        //{
        //    driver = new FirefoxDriver();

        //    MaximizeWindow();

        //    return driver;

        //}

        public void MaximizeWindow()
        {

            driver.Manage().Window.Maximize();


        }

        public void BrowserQuit()
        {
            driver.Quit();
        }

        public void EnterValueByLocator(By locator, string value)
        {


            driver.FindElement(locator).SendKeys(value);

        }

        public void ClickOnElement(By locator)
        {

            driver.FindElement(locator).Click();

        }


        public void ComboBoxByValue(By locator, string value)
        {

            IWebElement comboLocate = driver.FindElement(locator);
            SelectElement select = new SelectElement(comboLocate);

            select.SelectByValue(value);


        }








        //public IWebDriver BrowserOpen(string browser) // working right need to install nuget packages
        //{

        //    browser = browser.ToLower();

        //    driver = null;
        //    if (browser == "edge")
        //    {
        //        return EdgeOpen();
        //    }
        //    else if (browser == "chrome")
        //    {
        //        return ChromeOpen();
        //    }
        //    else if (browser == "chrome")
        //    {
        //        return FirefoxOpen();
        //    }

        //    return driver;

        //}



    }
}
