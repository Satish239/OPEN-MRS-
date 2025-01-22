using EaAutomationFramework.Confg;
using EaAutomationFramework.Driver;
using OPEN_MRS.Pages;

namespace OPEN_MRS
{
    public class UnitTest1
    {
       
        public IDriverFixture _driverFixture;
        

        public UnitTest1()
        {
            var testsettings = new TestSettings
            {
                 BrowserType = DriverFixture.BrowserType.Chrome,
                 ApllicationUrl = new Uri("https://demo.openmrs.org/openmrs/login.htm"),
                 TimeoutInterval = 30,
            };
            _driverFixture =  new DriverFixture(testsettings);
        }


        [Fact]

        public void Test1()
        {
            var  loginPage = new LoginPage(_driverFixture);
            var openMrsHomepage = new OpenMrsHomePage(_driverFixture);
            var registerPage = new RegisterPage(_driverFixture);
            var  patientRecordSheet = new PatientRecordSheet(_driverFixture);
            var patientPage = new PatientPage(_driverFixture);  

            loginPage.TextToUser();
            loginPage.TextToPass();
            loginPage.RegistrationDeskClick();
            loginPage.LoginBtnClk();
            loginPage.RegistrationValid();
            openMrsHomepage.RegisterPatient();
            openMrsHomepage.PatinetValidate();
            registerPage.Patinet();
            registerPage.MiddleNameOfPatient();
            registerPage.FamilyNameOfPatient();
            registerPage.PageNextBtn();
            registerPage.SelectMale();
            registerPage.PageNextBtn();
            registerPage.DataOfBirth();
            registerPage.BirthDayOfMonth();
            registerPage.BirthOfYear();
            registerPage.PageNextBtn();
            //registerPage.AddressOfPatient();
            //registerPage.CityName();
            //registerPage.CountryName();
            //registerPage.StateName();
            //registerPage.CountryName();
            //registerPage.PostelCodeNum();
            //registerPage.PageNextBtn();
            //registerPage.PhoneNumberOfPatient();
            //registerPage.PageNextBtn();
            //registerPage.RealationType();
            //registerPage.RealtiveName();
            //registerPage.PageNextBtn();
            registerPage.SubmitBtn();
            //registerPage.ValidatePatient();
            openMrsHomepage.FindPatient();
            patientRecordSheet.PatientSearch("Konda");
            patientRecordSheet.ClickField();
            //patientPage.StartVisitClk();
            patientPage.RequestPatientAppointment();
          var apponitmentRequestPage = new ApponitmentRequestPage(_driverFixture);

           apponitmentRequestPage.PatientAppointmentType();
           apponitmentRequestPage.SaveClk();
           

        }
    }
}