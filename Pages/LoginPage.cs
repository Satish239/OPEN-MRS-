using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EaAutomationFramework.Driver;
using EaAutomationFramework.Extensions;
using OpenQA.Selenium;

namespace OPEN_MRS.Pages
{
   public class LoginPage
    {

         WebElementExtention extensions = new WebElementExtention();
      
           private readonly IDriverFixture _driverFixture;

        public LoginPage(IDriverFixture driverFixture)
        {
            _driverFixture = driverFixture;
        }
        private IWebElement userName => _driverFixture.Driver.FindElement(By.XPath("//*[@id='username']"));
        private IWebElement password => _driverFixture.Driver.FindElement(By.XPath("//*[@id='password']"));
        private IWebElement inPatientWord => _driverFixture.Driver.FindElement(By.XPath("//*[@id='sessionLocation']/child::*[text()='Inpatient Ward']"));

        private IWebElement isolationWard=> _driverFixture.Driver.FindElement(By.XPath("//*[@id='sessionLocation']/child::*[text()='Isolation Ward']"));
        private IWebElement laboratory => _driverFixture.Driver.FindElement(By.XPath("//*[@id='sessionLocation']/child::*[text()='Laboratory']"));
        private IWebElement outpatientClinic => _driverFixture.Driver.FindElement(By.XPath("//*[@id='sessionLocation']/child::*[text()='Outpatient Clinic"));
        private IWebElement pharmacy => _driverFixture.Driver.FindElement(By.XPath("//*[@id='sessionLocation']/child::*[text()='Pharmacy']"));
        private IWebElement registrationDesk => _driverFixture.Driver.FindElement(By.XPath("//*[@id='sessionLocation']/child::*[text()='Registration Desk']"));
   
        private IWebElement logClk => _driverFixture.Driver.FindElement(By.XPath("//*[@id='loginButton']"));
        private IWebElement registrationValid => _driverFixture.Driver.FindElement(By.XPath("//*[@class='icon-map-marker small']/following-sibling::*[1]"));


        public  void TextToUser()
        {
            extensions.SendKeysToText(userName,"Admin");
        }
        public void TextToPass()
        {
            extensions.SendKeysToText(password, "Admin123");
        }
        public void RegistrationDeskClick()
        {
           extensions.ElementToClick(registrationDesk);
        }
        public void LoginBtnClk()
        {
            extensions.ElementToClick(logClk);
        }
        public void RegistrationValid()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driverFixture.Driver;

            if (registrationValid.Displayed)
            {
                js.ExecuteScript("arguments[0].style.border='10px solid yellow'", registrationValid);
            }
            else
            {
                _driverFixture.Driver.Close();
            }
        }

    }
}
