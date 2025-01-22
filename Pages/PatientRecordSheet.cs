using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Waiters;
using EaAutomationFramework.Driver;
using EaAutomationFramework.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace OPEN_MRS.Pages
{
    
    public class PatientRecordSheet : Wait
    {
         WebElementExtention Extensions = new WebElementExtention();
      
        public PatientRecordSheet(IDriverFixture driverFixture) : base(driverFixture)
        {
            _driverFixture = driverFixture;
        }
        private IWebElement PatientSearchBox => _driverFixture.Driver.FindElement(By.XPath("//*[contains(@id,'search-form')]/child::input[@id='patient-search']"));

        private IWebElement Clkfeild => _driverFixture.Driver.FindElement(By.XPath(" //tr[td[contains(text(),'Konda')]][1]"));
       

        public void PatientSearch(string name)
        {
            if (PatientSearchBox.Displayed)
            {
                WebdriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[contains(@id,'search-form')]/child::input[@id='patient-search']")));
                Extensions.SendKeysToText(PatientSearchBox,name);
                
            }
            else
            {
                Console.WriteLine("Patient Id Not found ");
            }
        }
        public void ClickField()
        {   
        WebdriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[contains(@id,'search-form')]/child::input[@id='patient-search']")));
            Extensions.ElementToClick(Clkfeild);
        }


    }
}
