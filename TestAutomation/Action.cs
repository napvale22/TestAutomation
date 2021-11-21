using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TestAutomation.BaseClass;

namespace TestAutomation.Action
{
    [TestFixture]
    public class Action : BaseTest
    {
        #region Objects

        IWebElement RabbitCareLogo => driver.FindElement(By.ClassName("flex-grow-1"));

        IWebElement TwentyFourHoursLogo => driver.FindElement(By.XPath("//*[@id='__next']/div[1]/div/div/div[2]/a[1]/div[2]/span[2]"));

        IWebElement LineLogo => driver.FindElement(By.XPath("//*[@id='__next']/div[1]/div/div/div[2]/a[2]"));

        IWebElement MessengerLogo => driver.FindElement(By.XPath("//*[@id='__next']/div[1]/div/div/div[2]/a[3]"));

        IWebElement InsuranceMilesone => driver.FindElement(By.XPath("//*[@id='__next']/div[3]/div/div/div/div/div/div[1]/div[1]"));

        IWebElement PersonalMilesone => driver.FindElement(By.XPath("//*[@id='__next']/div[3]/div/div/div/div/div/div[2]/div[1]"));

        IWebElement QuotesMilestone => driver.FindElement(By.XPath("//*[@id='__next']/div[3]/div/div/div/div/div/div[3]/div[1]"));

        IWebElement InsuranceSectionTitle => driver.FindElement(By.XPath("//*[@id='__next']/main/div/div/form/div[1]/h2"));

        IWebElement IPDOPDCard => driver.FindElement(By.XPath("//*[@id='product_category']/div[2]/div/div[1]"));

        IWebElement SpecificDiseaseCard => driver.FindElement(By.XPath("//*[@id='product_category']/div[2]/div/div[2]"));

        IWebElement PersonalAccidentCard => driver.FindElement(By.XPath("//*[@id='product_category']/div[2]/div/div[3]"));

        IWebElement SDOption1 => driver.FindElement(By.XPath("//*[@id='product_disease_subcategory']/div[2]/div/div[1]"));

        IWebElement HAPBtn => driver.FindElement(By.XPath("//*[@id='ipdopdcoverage']/div[2]/div[1]/div/div[2]/div/div/div[1]"));

        IWebElement HAPNextBtn => driver.FindElement(By.XPath("//*[@id='ipdopdcoverage']/div[2]/div[2]/div/button"));

        IWebElement InputDOB => driver.FindElement(By.XPath("//*[@id='customer_dob']/div[1]/div/div[2]/input"));

        #endregion

        #region Actions

        [Test]
        // <description>
        //   Verify that the following are displayed:
        //    - rabbitcare(title)
        //    - Complete Care
        //    - Phone 24 hours(button)
        //    - Line icon(button)
        //    - Messenger icon(button)
        //    - Insurance(Milestone)
        //    - Personal(Milestone)
        //    - Quotes(Milestone)
        //    - Title Card
        //    - Clickable Cards Option
        // </description>
        public void TC1()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(RabbitCareLogo.Displayed);
            Console.WriteLine("Rabbit Care Logo is present");

            Assert.IsTrue(TwentyFourHoursLogo.Displayed);
            Console.WriteLine("Twenty Four Hours icon is present");

            Assert.IsTrue(LineLogo.Displayed);
            Console.WriteLine("Line icon is present");

            Assert.IsTrue(MessengerLogo.Displayed);
            Console.WriteLine("Messenger icon is present");

            Assert.IsTrue(InsuranceMilesone.Displayed);
            Console.WriteLine("Insurance Milestone indicator is present");

            Assert.IsTrue(PersonalMilesone.Displayed);
            Console.WriteLine("Personal Milestone indicator is present");

            Assert.IsTrue(QuotesMilestone.Displayed);
            Console.WriteLine("Quotes Milestone indicator is present");

            Assert.IsTrue(InsuranceSectionTitle.Displayed);
            Console.WriteLine("Insurance Section title is present");

            Assert.IsTrue(IPDOPDCard.Displayed);
            Console.WriteLine("IPD/OPD card is present");

            Assert.IsTrue(SpecificDiseaseCard.Displayed);
            Console.WriteLine("Specific Disease card is present");

            Assert.IsTrue(PersonalAccidentCard.Displayed);
            Console.WriteLine("Personal Accident card is present");

            Thread.Sleep(2000);
        }

        [Test]
        // <description>
        //   Verify that the date of birth field only accepts 
        //   numeric values with a format DD/MM/YYY
        // </description>
        public void TC8()
        {
            SpecificDiseaseCard.Click();
            Thread.Sleep(1500);
            SDOption1.Click();
            HAPBtn.Click();
            HAPNextBtn.Click();

            InputDOB.SendKeys("sample char");

            string DOBValue = InputDOB.GetAttribute("value");

            if (!String.IsNullOrEmpty(DOBValue))
            {
                throw new Exception("TC8 Failed: Input field accepts string");
            }
        }

        #endregion
    }
}
