using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrangeHrmAutomationMsTest.PageObject.Admin
{

    [TestClass]
    public class AdminPageTC : Execution
    {


        BasePage usableFunctions = new BasePage();
        LoginPageTC loginPage = new LoginPageTC();
        AdminPage adminPage = new AdminPage();


        [TestMethod]
        public void ClickOnAdminButton()
        {

            loginPage.LoginWithValidUsernameValidPassword();

            adminPage.usernameValue = "Huzaifa";
            adminPage.employeeNameValue = "HamzaSheikh";

            adminPage.AdminClick();




        }


    }
}
