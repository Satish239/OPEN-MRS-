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
   
   public class RegisterPage : Wait
    {  
        public RegisterPage(IDriverFixture driverFixture) : base(driverFixture)
        { 
            _driverFixture = driverFixture;
        }
        private IWebElement  PatinetName=> _driverFixture.Driver.FindElement(By.XPath("//*[@name='givenName']"));
        private IWebElement MiddleName => _driverFixture.Driver.FindElement(By.XPath("//*[@name='middleName']"));
        private IWebElement FamilyName => _driverFixture.Driver.FindElement(By.XPath("//*[@name='familyName']"));
        private IWebElement NextBtn => _driverFixture.Driver.FindElement(By.XPath("//*[@id='next-button']"));
        private IWebElement Selectbtn => _driverFixture.Driver.FindElement(By.XPath("//*[@id='gender-field']"));     
        private IWebElement DateOfBirth => _driverFixture.Driver.FindElement(By.XPath(" //*[@id='birthdateDay-field']"));
        private IWebElement BirthDateMonth => _driverFixture.Driver.FindElement(By.XPath(" //*[@id='birthdateMonth-field']"));
        private IWebElement BirthDateYear => _driverFixture.Driver.FindElement(By.XPath(" //*[@id='birthdateYear-field']"));
        private IWebElement Address => _driverFixture.Driver.FindElement(By.XPath("//*[@id='address1']"));
        private IWebElement City => _driverFixture.Driver.FindElement(By.XPath("//*[@id='cityVillage']"));
        private IWebElement State => _driverFixture.Driver.FindElement(By.XPath("//*[@id='stateProvince']"));
        private IWebElement Country => _driverFixture.Driver.FindElement(By.XPath("//*[@id='country']"));
        private IWebElement PostelCode => _driverFixture.Driver.FindElement(By.XPath("//*[@id='postalCode']"));
        private IWebElement PhoneNumber => _driverFixture.Driver.FindElement(By.XPath(" //*[@name='phoneNumber']"));
        private IWebElement SelectRelation => _driverFixture.Driver.FindElement(By.XPath(" //*[@id='relationship_type']"));  
        private IWebElement RelationName => _driverFixture.Driver.FindElement(By.XPath("//*[@id='relationship_type']/following::*[1]/child::*"));
        private IWebElement DetailsSubmit => _driverFixture.Driver.FindElement(By.XPath("//*[@id='submit']"));

        private IWebElement ValidatePatientId => _driverFixture.Driver.FindElement(By.XPath("//*[text()='Patient ID']/following-sibling::span"));
        WebElementExtention Extensions = new WebElementExtention();
        public void Patinet()
        {
            Extensions.SendKeysToText(PatinetName,"Konda");
        }

        public void MiddleNameOfPatient()
        {
            Extensions.SendKeysToText(MiddleName, "Babu");
        }
        public void FamilyNameOfPatient()
        {
            Extensions.SendKeysToText(FamilyName, "Katta");
        }
        public void PageNextBtn()
        {
            Extensions.ElementToClick(NextBtn);
        }
        public void SelectMale()
        {
            Extensions.SelectDropDownByValue(Selectbtn,"M");
        }
        public void DataOfBirth()
        {
            Extensions.SendKeysToText(DateOfBirth, "31");
        }
        public void BirthDayOfMonth()
        {
            Extensions.SelectDropDownByValue(BirthDateMonth,"8");
        }
        public void BirthOfYear()
        {
            Extensions.SendKeysToText(BirthDateYear, "2003");
        }
        public void AddressOfPatient()
        {
            Extensions.SendKeysToText(Address,"5-790 srinagar Sr Nagar Hyderabad ");
        }

        public void CityName()
        {
            Extensions.SendKeysToText(City, "Hyderabad");
        }
        public void CountryName()
        {
            Extensions.SendKeysToText(Country, "India");
        }
        public void StateName()
        {
            Extensions.SendKeysToText(State, "Telegana");
        }
        public void PostelCodeNum()
        {
            Extensions.SendKeysToText(PostelCode, "533400");
        }
        public void PhoneNumberOfPatient()
        {
            Extensions.SendKeysToText(PhoneNumber, "9876543212");
        }
        public void RealationType()
        {
            Extensions.SelectDropDownByText(SelectRelation, "Sibling");
        }
        public void RealtiveName()
        {
            Extensions.SendKeysToText(RelationName,"Sairam");
        }
        public void SubmitBtn()
        {

            Extensions.ElementToClick(DetailsSubmit);
        }
           public void ValidatePatient()
           {
        

                WebdriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[text()='Patient ID']/following-sibling::span")));
                IJavaScriptExecutor js = (IJavaScriptExecutor)_driverFixture.Driver;
                if (ValidatePatientId.Displayed)
                {
                    js.ExecuteScript("arguments[0].style.border='10px solid yellow'", ValidatePatientId);

                }
                else
                {
                    Console.WriteLine($"Text is not Found{ValidatePatientId}");
                    _driverFixture.Driver.Quit();
                }
            }

           
        
    }
}
