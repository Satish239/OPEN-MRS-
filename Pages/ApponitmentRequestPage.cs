using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Waiters;
using EaAutomationFramework.Driver;
using EaAutomationFramework.Extensions;
using OpenQA.Selenium;

namespace OPEN_MRS.Pages
{
   public class ApponitmentRequestPage :Wait
    {
       
        public ApponitmentRequestPage(IDriverFixture driverFixture) : base(driverFixture) 
        {
            this._driverFixture = driverFixture;
        }
        WebElementExtention extensions = new WebElementExtention();
        private IWebElement AppointmentType => _driverFixture.Driver.FindElement(By.XPath("//*[@id='appointment-type']"));
        private IWebElement AppointmentProvider => _driverFixture.Driver.FindElement(By.XPath("//*[@id='provider']"));

        private IWebElement SaveClkBtn => _driverFixture.Driver.FindElement(By.XPath("//*[@id='save-button']"));

        private IWebElement RequestApt => _driverFixture.Driver.FindElement(By.XPath("//*[contains(text(),'Dermatology (New Patient)')][1]"));
        public void PatientAppointmentType()
        {
            WebdriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='appointment-type']")));
            extensions.ElementToClick(AppointmentType);
            extensions.SendKeysToText(AppointmentType, "Dermatology");
            WebdriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("ul.dropdown-menu")));
            extensions.ElementToClick(AppointmentType);
            AppointmentType.SendKeys(Keys.ArrowDown); // Navigate to the first option
            AppointmentType.SendKeys(Keys.Enter);    // Select the option
        }
        
        public void SaveClk()
        {
            extensions.ElementToClick(SaveClkBtn);
        }
    }
}
