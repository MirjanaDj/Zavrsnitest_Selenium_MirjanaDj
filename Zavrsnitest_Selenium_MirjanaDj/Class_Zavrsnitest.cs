using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.IO;




namespace Zavrsnitest_Selenium_MirjanaDj
{
    class Class_Zavrsnitest
    {
        IWebDriver driver;

        [SetUp]
        public void OpenBrowser()
        {
            driver = new ChromeDriver();
        }

        public void GoToUrl(string url)
        {
            this.driver.Url = url;
        }

        [Test]
        public void TC001()
        {
            GoToUrl("https://courses.ultimateqa.com/");
            Thread.Sleep(5000);


            Thread.Sleep(5000);

            System.IO.File.AppendAllText("C:\\Users\\Djuric\\Desktop\\QA kurs - Mira\\Selenium log\\LogSelenium.txt", DateTime.Now + " Message is displayed. " + Environment.NewLine);

        }

        [Test]
        public void TC002()
        {
            GoToUrl("https://courses.ultimateqa.com/");
            Thread.Sleep(5000);


            Thread.Sleep(5000);

            System.IO.File.AppendAllText("C:\\Users\\Djuric\\Desktop\\QA kurs - Mira\\Selenium log\\LogSelenium.txt", DateTime.Now + " Message is displayed. " + Environment.NewLine);

        }



        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }











    }

}
