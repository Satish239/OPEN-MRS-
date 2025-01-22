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
   public class OpenMrsHomePage: Wait
    {
        WebElementExtention Extensions = new WebElementExtention();
       
        public OpenMrsHomePage(IDriverFixture driverFixture): base(driverFixture) 
        { 
            _driverFixture = driverFixture;
        }
        private IWebElement findPatientRecord => _driverFixture.Driver.FindElement(By.XPath("//*[@id='apps']/child::*[contains(@id,'coreapps')]"));
        private IWebElement activeVisits => _driverFixture.Driver.FindElement(By.XPath("//*[@id='apps']/child::*[2]"));
        private IWebElement captureVitals => _driverFixture.Driver.FindElement(By.XPath("//*[@id='apps']/child::*[3]"));
        private IWebElement registerPatient => _driverFixture.Driver.FindElement(By.XPath("//*[contains(@id,'registrationapp')]"));
        private IWebElement appointmentSchedual => _driverFixture.Driver.FindElement(By.XPath("//*[@id='apps']/child::*[5]"));
        private IWebElement reports  => _driverFixture.Driver.FindElement(By.XPath("//*[@id='apps']/child::*[6]"));
        private IWebElement dataManagement => _driverFixture.Driver.FindElement(By.XPath("//*[@id='apps']/child::*[7]"));
        private IWebElement configureMetadata=> _driverFixture.Driver.FindElement(By.XPath("//*[@id='apps']/child::*[8]"));
        private IWebElement systemAdminstartion => _driverFixture.Driver.FindElement(By.XPath("//*[@id='apps']/child::*[9]"));
        private IWebElement patientValidate => _driverFixture.Driver.FindElement(By.XPath("//*[contains(text(),'Register')][2]"));

        
        public void RegisterPatient()
        {

            Extensions.ElementToClick(registerPatient);
        }
        public void PatinetValidate()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driverFixture.Driver;
            if (patientValidate.Displayed)
            {
                js.ExecuteScript("arguments[0].style.border='10px solid yellow'", patientValidate);
            }
            else
            {
                _driverFixture.Driver.Close();
            }
        }
        public void FindPatient()
        {
            WebdriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='apps']/child::*[contains(@id,'coreapps')]")));
            Extensions.ElementToClick(findPatientRecord);
        }
       
    }
}
