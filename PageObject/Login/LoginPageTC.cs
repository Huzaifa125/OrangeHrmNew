using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OrangeHrmAutomationMsTest.PageObject.Login;
using System;
using System.Threading;

namespace OrangeHrmAutomationMsTest.PageObject
{
    [TestClass]
    public class LoginPageTC : Execution
    {

        LoginPage loginPage = new LoginPage();

        [TestMethod]
        [Owner("Huzaifa")]
        [Description("")]
        public void LoginWithValidUsernameValidPassword()
        {


            loginPage.username = "admin";
            loginPage.password = "admin123";
            loginPage.url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            loginPage.Login();

        }


    }
}
