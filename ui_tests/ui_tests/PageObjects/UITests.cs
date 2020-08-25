using Common;
using Common.PageObjects;
using Common.Utility;
using NFluent;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UITests
{
    public class UITests 
    {
        public UITests(GlobalSettings settings) : base(settings) { }

        #region XPath Page Elements

        private const string _signInButtonXPath = @"//a[@class='login']";
        private const string _enterEmailXPath = @"//input[@id='email_create']";
        private const string _createAccountButtonXPath = @"//button[@id='SubmitCreate']";
        private const string _titleXPath = @"//input[@id='id_gender2']";
        private const string _firstNameXPath = @"//input[@id='customer_firstname']";
        private const string _lastNameXPath = @"//input[@id='customer_lastname']";
        private const string _passwordXPath = @"//input[@id='passwd']";
        private const string _addressXPath = @"//input[@id='address1']";
        private const string _cityXPath = @"//input[@id='city']";
        private const string _stateXPath = @"//select[@id='id_state']";
        private const string _zipRegionXPath = @"//input[@id='postcode']";
        private const string _countryXPath = @"//select[@id ='id_country']";
        private const string _mobilePhoneXPath = @"//input[@id='phone_mobile']";
        private const string _submitAccountButtonXPath = @"//button[@id='submitAccount']";
        private const string _createAccountErrorXPath = @"//div[@id='create_account_error']";
        private const string _emailAddessXPath = @"//input[@id='email']";
        private const string _passwordAddessXPath = @"//input[@id='passwd']";
        private const string _submitLoginButtonXPath = @"//button[@id='SubmitLogin']";
        private const string _alertMessageXPath = @"//div[contains(@Class,'alert-danger')]";
        private const string _womenMenuXPath = @"//a[text()='Women']";
        private const string _searchTermXPath = @"//input[@id='search_query_top']";
        private const string _searchButtonXPath = @"//button[@name='submit_search']";
        private const string _addCartButtonXPath = @"//a[@title='Add to cart']";
        #endregion

        #region IWebElement

        public IWebElement _signInButton
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_signInButtonXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }

        public IWebElement _enterEmail
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_enterEmailXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }

        public IWebElement _createAccountButton
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_createAccountButtonXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }

        public IWebElement _title
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_titleXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }

        public IWebElement _firstName
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_firstNameXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }

        public IWebElement _lastName
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_lastNameXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }

        public IWebElement _password
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_passwordXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }

        public IWebElement _address
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_addressXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }

        public IWebElement _city
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_cityXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }

        public IWebElement _state
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_stateXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }

        public IWebElement _zipRegion
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_zipRegionXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }

        public IWebElement _country
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_countryXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }

        public IWebElement _mobilePhone
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_mobilePhoneXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }

        public IWebElement _submitAccountButton
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_submitAccountButtonXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }

        public IWebElement _createAccountError
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_createAccountErrorXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }


        public IWebElement _emailAddess
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_emailAddessXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }

        public IWebElement _passwordAddess
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_passwordAddessXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }

        public IWebElement _submitLoginButton
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_submitLoginButtonXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }
        public IWebElement _alertMessage
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_alertMessageXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }

        public IWebElement _womenMenu
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_womenMenuXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }
        public IWebElement _searchTerm
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_searchTermXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }

        public IWebElement _searchButton
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_searchButtonXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }

        public IWebElement _addCartButton
        {
            get
            {
                bool found = Driver.TryWaitForElementToBeVisible(By.XPath(_addCartButtonXPath), out IWebElement element);
                Check.That(found).IsTrue();
                return element;
            }
        }
        #endregion

        /// <summary>
        /// Click on SiginButton
        /// </summary>
        public void SiginClick()
        {
            _signInButton.Click();
        }

        /// <summary>
        /// Get / Set EnterEmail
        /// </summary>
        public string EnterEmail
        {
            get { return _enterEmail.Text; }
            set
            {
                _enterEmail.SendKeys(value);
            }
        }

        /// <summary>
        /// Click on CreateAccountButton 
        /// </summary>
        public void CreateAccountButtonClick()
        {
            _createAccountButton.Click();
        }

        /// <summary>
        /// Click on CreateAccountButton 
        /// </summary>
        public void TitleClick()
        {
            _title.Click();
        }

        /// <summary>
        /// Get / Set FirstName
        /// </summary>
        public string FirstName
        {
            get { return _firstName.Text; }
            set
            {
                _firstName.SendKeys(value);
            }
        }

        /// <summary>
        /// Get / Set LastName
        /// </summary>
        public string LastName
        {
            get { return _lastName.Text; }
            set
            {
                _lastName.SendKeys(value);
            }
        }

        /// <summary>
        /// Get / Set Password
        /// </summary>
        public string Password
        {
            get { return _password.Text; }
            set
            {
                _password.SendKeys(value);
            }
        }

        /// <summary>
        /// Get / Set Address
        /// </summary>
        public string Address
        {
            get { return _address.Text; }
            set
            {
                _address.SendKeys(value);
            }
        }

        /// <summary>
        /// Get / Set City
        /// </summary>
        public string City
        {
            get { return _city.Text; }
            set
            {
                _city.SendKeys(value);
            }
        }

        /// <summary>
        /// Get / Set State
        /// </summary>
        public void SetState(string whichText)
        {
            var selectElement = new SelectElement(_state);
            selectElement.SelectByText(whichText);
        }

        /// <summary>
        /// Get / Set ZipRegion
        /// </summary>
        public string ZipRegion
        {
            get { return _zipRegion.Text; }
            set
            {
                _zipRegion.SendKeys(value);
            }
        }

        /// <summary>
        /// Get / Set Country
        /// </summary>
        public void SetCountry(string whichText)
        {
            var selectElement = new SelectElement(_country);
            selectElement.SelectByText(whichText);
        }

        /// <summary>
        /// Get / Set MobilePhone
        /// </summary>
        public string MobilePhone
        {
            get { return _mobilePhone.Text; }
            set
            {
                _mobilePhone.SendKeys(value);
            }
        }

        /// <summary>
        /// Click on SubmitAccountClick 
        /// </summary>
        public void SubmitAccountClick()
        {
            _submitAccountButton.Click();
        }

        /// <summary>
        /// Get CreateAccountError message
        /// </summary>
        public string CreateAccountError
        {
            get { return _createAccountError.Text; }
        }

        /// <summary>
        /// Get / Set EmailAddess
        /// </summary>
        public string EmailAddess
        {
            get { return _emailAddess.Text; }
            set
            {
                _emailAddess.SendKeys(value);
            }
        }

        /// <summary>
        /// Get / Set PasswordAddess
        /// </summary>
        public string PasswordAddess
        {
            get { return _passwordAddess.Text; }
            set
            {
                _passwordAddess.SendKeys(value);
            }
        }

        /// <summary>
        /// Click on SubmitAccountClick 
        /// </summary>
        public void SubmitLoginClick()
        {
            _submitLoginButton.Click();
        }

        /// <summary>
        /// Get / Set AlertMessage
        /// </summary>
        public string AlertMessage
        {
            get { return _alertMessage.Text; }
            set
            {
                _alertMessage.SendKeys(value);
            }
        }

        /// <summary>
        /// Click on SiginButton
        /// </summary>
        public void WomenMenuClick()
        {
            _womenMenu.Click();
        }

        /// <summary>
        /// Set SearchTerm
        /// </summary>
        public string SearchTerm
        {
            set
            {
                _searchTerm.SendKeys(value);
            }
        }

        /// <summary>
        /// Click on SearchButtonClick 
        /// </summary>
        public void SearchButtonClick()
        {
            _searchButton.Click();
        }

        /// <summary>
        /// Click on SiginButton
        /// </summary>
        public void AddCartClick()
        {
            _addCartButton.Click();
        }
    }
}
