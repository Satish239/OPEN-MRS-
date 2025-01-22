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
      public class PatientPage :Wait
    {
       
        public PatientPage(IDriverFixture driverFixture) : base(driverFixture)
        {
            _driverFixture = driverFixture;
        }
        WebElementExtention Extensions = new WebElementExtention(); 
        private IWebElement StartVisit => _driverFixture.Driver.FindElement(By.XPath("//*[text()='General Actions']/following::li[1]/child::*"));
        private IWebElement VisitType => _driverFixture.Driver.FindElement(By.XPath("//*[contains(@id,'StartDate-display')]"));
        private IWebElement ConfirmType => _driverFixture.Driver.FindElement(By.XPath(" //*[contains(@id,'-confirm')]"));

        private IWebElement RequestAppointment => _driverFixture.Driver.FindElement(By.XPath("//*[text()='General Actions']/following::li[5]/child::*"));


        public void RequestPatientAppointment()
        {
            try
            {
                WebdriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[text()='General Actions']/following::li[5]/child::*")));
                
            }
            catch (ElementNotVisibleException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                Extensions.ElementToClick(RequestAppointment);
            }
        }

    }
}
