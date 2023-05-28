using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrmAutomationMsTest.PageObject.Login
{
    public partial class LoginPage
    {

        #region Locators
        By txtUsername = By.Name("username");
        By txtPassword = By.Name("password");
        By btnLogin = By.XPath("//button[normalize-space()='Login']");
        #endregion


    }
}
