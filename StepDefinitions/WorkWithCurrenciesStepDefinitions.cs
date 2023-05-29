using BDD.Pages;

namespace BDD.StepDefinitions
{
    [Binding]
    public class WorkWithCurrenciesStepDefinitions
    {
        #region init pages
        private readonly LoginPage _loginPage;
        private readonly SearchPage _searchPage;
        private readonly AdminHeader _adminHeader;
        private readonly Currencies _currencies;
        private readonly PayGrades _payGrades;
        private readonly SurePopUp _surePopUp;

        public WorkWithCurrenciesStepDefinitions(LoginPage loginPage, SearchPage searchPage, AdminHeader adminHeader,
            Currencies currencies, PayGrades payGrades, SurePopUp surePopUp)
        {
            _loginPage = loginPage;
            _searchPage = searchPage;
            _adminHeader = adminHeader;
            _currencies = currencies;
            _payGrades = payGrades;
            _surePopUp = surePopUp;
        }
        #endregion

        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        [Given(@"user open home page (.*)")]
        public void UserOpenHomePage(string url)
        {
            _loginPage.SeleniumActions.OpenUrl(url);

        }

        [Given(@"user login into system")]
        public void UserLoginIntoSystem(KeyValuePair<string, string> credentials)
        {
            _loginPage
                .SeleniumActions.EntTextInTextBox(_loginPage._username, credentials.Key)
                .EntTextInTextBox(_loginPage._password, credentials.Value)
                .Click(_loginPage._login);
        }

        [When(@"user choose admin tab")]
        public void UserChooseAdminTab()
        {
            _searchPage
                .SeleniumActions.Click(_searchPage._admin);
        }

        [When(@"user choose Pay Grades from drop down menu")]
        public void UserChoosePayGradesFromDropDownMenu()
        {
            _adminHeader
                .SeleniumActions.Click(_adminHeader._job)
                .FindElementInCollection(_adminHeader._dropDownElements, "Pay Grades").Click();
        }

        [When(@"user add new pay grades")]
        public void UserAddNewPayGrades()
        {
            string randomString = new(Enumerable.Repeat(chars, 6).Select(s => s[new Random().Next(s.Length)]).ToArray());

            _payGrades.SeleniumActions
                .Click(_payGrades._addButton)
                .EntTextInTextBox(_payGrades._payGrade, randomString)
                .Click(_payGrades._saveButton);
        }

        [When(@"user enter min salary (.*) and max salary (.*)")]
        public void UserEnterMinAndMaxSalary(string minimumSalary, string maximumSalary)
        {

            _currencies.SeleniumActions
                            .Click(_currencies._addButton)
                            .Click(_currencies._currencyField)
                            .Click(_currencies._currencyFieldFirst)
                            .EntTextInTextBox(_currencies._minimumSalary, minimumSalary)
                            .EntTextInTextBox(_currencies._maximumSalary, maximumSalary);
        }

        [When(@"user click on save button")]
        public void UserClickOnSaveButton()
        {
            _currencies.SeleniumActions
                            .Click(_currencies._saveButton);
        }

        [When(@"user click on cancel button")]
        public void UserClickOnCancelButton()
        {
            _currencies.SeleniumActions
                            .Click(_currencies._cancelButton);
        }

        [Then(@"user check min (.*) and max (.*) salary added")]
        public void UserCheckMinAndMaxSalaryAdded(string minimumSalary, string maximumSalary)
        {
            _currencies.SeleniumActions
                            .VerifyTextPresentInElement(_currencies._minimumSalaryText, minimumSalary)
                            .VerifyTextPresentInElement(_currencies._maximumSalaryText, maximumSalary);
        }

        [Then(@"user check min and max salary did not added")]
        public void UserCheckMinAndMaxSalaryDidNotAdded()
        {
            _currencies.SeleniumActions
               .VerifyTextPresentInElement(_currencies._emptyCurrenciesText, "No Records Found");
        }
    }
}