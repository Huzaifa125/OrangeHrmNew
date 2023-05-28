using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace OrangeHrmAutomationMsTest
{
    [TestClass]
    public class Execution : BasePage
    {

        public static ChromeOptions options = new ChromeOptions();


        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            Console.WriteLine("");
        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            Console.WriteLine("");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            //string[] browserArray = { "edge", "chrome" ,"firefox"};

            //foreach (string browser in browserArray)
            //{
            ChromeOpen();
                // foreach (string browser in browserArray)
                // {
                //     usableFunctions.BrowserOpen(browser);
                // }

            //}

        }

        [TestCleanup]
        public void Cleanup()
        {
            //driver.Quit();

        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Console.WriteLine("");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Console.WriteLine("");
        }
    }
}
