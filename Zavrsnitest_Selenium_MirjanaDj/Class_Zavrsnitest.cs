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
        public void QATodorovTC001()
        {
            GoToUrl("http://qaf.todorowww.net/");
            Thread.Sleep(5000);

            IWebElement FirstName = driver.FindElement(By.Name("Ime"));
            IWebElement LastName = driver.FindElement(By.Id("Prezime"));
            IWebElement email = driver.FindElement(By.XPath("//input[@type='email']"));
            IWebElement Password = driver.FindElement(By.Id("Lozinka"));

            IWebElement Continent = driver.FindElement(By.XPath("//select[@name='Kontinent']/option[@value='Australija']"));
            Continent.Click();
            Thread.Sleep(3000);

            IWebElement Country = driver.FindElement(By.XPath("//select[@name='Zemlja']/option[@value='554']"));
            Country.Click();
            Thread.Sleep(3000);

            IWebElement City = driver.FindElement(By.Id("Grad"));
            IWebElement Contact = driver.FindElement(By.Id("KontaktMobilni"));
            Contact.Click();
            Thread.Sleep(3000);

            IWebElement Number = driver.FindElement(By.Name("Broj"));
            IWebElement Submitb = driver.FindElement(By.Id("Posalji"));

            string InFirstName = "Piter";
            string InLastName = "Savic";
            string InEmail = "piter.savic@bla.com";
            string InPassword = "Piter1234";
            string InCity = "Hakuna Matata";
            string InNumber = "+123456";

            FirstName.SendKeys(InFirstName);
            LastName.SendKeys(InLastName);
            email.SendKeys(InEmail);
            Password.SendKeys(InPassword);
            City.SendKeys(InCity);
            Number.SendKeys(InNumber);
            Submitb.Click();
            Thread.Sleep(3000);

            IWebElement message = driver.FindElement(By.XPath("//div[@id='rezultat']/span"));
            bool msgisDisplayed = message.Displayed;
            string msgtext = message.Text;
            string msgFName = FirstName.Text;
            string msgLName = LastName.Text;
            string msgEmail = email.Text;
            bool msgpart1 = msgtext.Contains(msgFName);
            bool msgpart2 = msgtext.Contains(msgLName);
            bool msgpart3 = msgtext.Contains(msgEmail);
            bool PassFail = (msgisDisplayed & msgpart1 & msgpart2 & msgpart3);
            string result = Convert.ToString(PassFail);
            System.IO.File.AppendAllText("C:\\Users\\Djuric\\Desktop\\QA kurs - Mira\\Selenium log\\LogSelenium.txt", DateTime.Now + " Message is displayed. " + PassFail + Environment.NewLine);


            Thread.Sleep(5000);


        }

        [Test]
        public void QATodorovTC002()
        {
            GoToUrl("http://qaf.todorowww.net/");
            Thread.Sleep(5000);

            IWebElement FirstName = driver.FindElement(By.XPath("//input[@id='Ime']"));
            string InFirstName = "Piter";
            FirstName.SendKeys(InFirstName);

            IWebElement LastName = driver.FindElement(By.XPath("//input[@id='Prezime']"));
            string InLastName = "Savic";
            LastName.SendKeys(InLastName);

            IWebElement email = driver.FindElement(By.XPath("//input[@type='email']"));
            string InEmail = "piter.savic@bla.com";
            email.SendKeys(InEmail);


            IWebElement Password = driver.FindElement(By.XPath("//input[@name='Lozinka']"));
            string InPassword = "Piter1234";
            Password.SendKeys(InPassword);


            IWebElement Continent = driver.FindElement(By.XPath("//select[@name='Kontinent']/option[@value='Australija']"));
            Continent.Click();
            Thread.Sleep(3000);

            IWebElement Country = driver.FindElement(By.XPath("//select[@name='Zemlja']/option[@value='554']"));
            Country.Click();
            Thread.Sleep(3000);

            IWebElement City = driver.FindElement(By.XPath("//input[@name='Grad']"));
            string InCity = "Hakuna Matata";
            City.SendKeys(InCity);

            IWebElement Contact = driver.FindElement(By.XPath("//input[@id='KontaktMobilni']"));
            Contact.Click();
            Thread.Sleep(3000);

            IWebElement Number = driver.FindElement(By.XPath("//input[@id='Broj']"));
            string InNumber = "+123456";
            Number.SendKeys(InNumber);

            IWebElement Submitb = driver.FindElement(By.XPath("//button[@id='Posalji']"));
            Submitb.Click();
            Thread.Sleep(3000);

            IWebElement message = driver.FindElement(By.XPath("//div[@id='rezultat']/span"));
            bool msgisDisplayed = message.Displayed;
            string msgtext = message.Text;
            string msgFName = FirstName.Text;
            string msgLName = LastName.Text;
            string msgEmail = email.Text;
            bool msgpart1 = msgtext.Contains(msgFName);
            bool msgpart2 = msgtext.Contains(msgLName);
            bool msgpart3 = msgtext.Contains(msgEmail);
            bool PassFail = (msgisDisplayed & msgpart1 & msgpart2 & msgpart3);
            string result = Convert.ToString(PassFail);
            System.IO.File.AppendAllText("C:\\Users\\Djuric\\Desktop\\QA kurs - Mira\\Selenium log\\LogSelenium.txt", DateTime.Now + " Message is displayed. " + PassFail + Environment.NewLine);

            //bonus
            IWebElement message2 = driver.FindElement(By.XPath("//span[contains(.,'Hakuna')]"));
            bool chek1 = message2.Displayed;
            string message2text = message2.Text;
            string var1 = City.Text;
            string var2 = Continent.Text;
            string var3 = Country.Text;
            string msgnumber = Number.Text;
            string zagrade = "(" + msgnumber + ")";
            bool chek2 = message2text.Contains(var1 + var2 + var3 + zagrade);

            bool PassFail1 = (chek1 & chek2);
            System.IO.File.AppendAllText("C:\\Users\\Djuric\\Desktop\\QA kurs - Mira\\Selenium log\\LogSelenium.txt", DateTime.Now + " Message2 is displayed. " + PassFail1 + Environment.NewLine);



            Thread.Sleep(5000);
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }





    }

}
