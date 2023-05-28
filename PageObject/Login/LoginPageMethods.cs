using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrmAutomationMsTest.PageObject.Login
{
    public partial class LoginPage : BasePage
    {

        #region Properties
        public string username { get; set; }
        public string url { get; set; }
        public string password { get; set; }
        #endregion



        public void Login()
        {
            driver.Url = url;


            EnterValueByLocator(txtUsername, username);
            EnterValueByLocator(txtPassword, password);

            driver.FindElement(btnLogin).Click();




        }

    }
}
