using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrmAutomationMsTest.PageObject.Admin
{
    public partial class AdminPage
    {
        #region Locators
        By BTNAdmin = By.XPath("//span[normalize-space()='Admin']");
        By TxtUsername = By.XPath("//div[@class='oxd-input-group oxd-input-field-bottom-space']//div//input[@class='oxd-input oxd-input--active']");
        By TxtEmployeeName = By.XPath("//input[@placeholder='Type for hints...']");
        #endregion



    }
}
