using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrmAutomationMsTest.PageObject.Admin
{
    public partial class AdminPage : BasePage
    {
        #region Properties
        public string usernameValue { get; set; }
        public string employeeNameValue { get; set; }
        public string password { get; set; }
        #endregion



        public void AdminClick()
        {

            ClickOnElement(BTNAdmin);

            EnterValueByLocator(TxtUsername, usernameValue);
            EnterValueByLocator(TxtEmployeeName, employeeNameValue);





        }



    }
}
