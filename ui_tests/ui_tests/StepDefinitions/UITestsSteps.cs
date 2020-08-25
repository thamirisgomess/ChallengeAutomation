using Castle.Core.Internal;
using Common;
using Common.StepDefinitions;
using Common.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.Linq;
using TechTalk.SpecFlow;
using PageObjects.UITests;

namespace ui_tests.Feature.UITests
{
    public class UITestsSteps 
    {
        //UITestsSteps(GlobalSettings Settings) : base(Settings) { }

        [Given(@"I navigate to automationpractice website")]
        public void GivenINavigateToAutomationpracticeWebsite()
        {
            try
            {
                IWebDriver driver = ChromeDriver();
                driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["automationpractice"]);
                Assert.Equals("automationpractice", driver.Title);
            }
            catch (Exception ex)
            {
                Logger.LogError($"Exception caught in '{Settings.Scenario.StepContext.StepInfo.Text}', {ex.Message}");
                throw ex;
            }
            finally
            {
                Logger.EndStepLog(Settings.Scenario.StepContext.StepInfo.Text);
            }
        }

        [Given(@"I go to click on Sign in button, enter Email address ""(.*)"" and click Create an account button")]
        public void GivenIGoToClickOnSignInButtonEnterEmailAddressAndClickCreateAnAccountButton(string email)
        {
            try
            {
                UITests _uITests = new UITests(Settings);
                _uITests.WaitForLoad();

                _uITests.SiginClick();
                _uITests.EnterEmail = email;
                _uITests.CreateAccountButtonClick();
            }
            catch (Exception ex)
            {
                Logger.LogError($"Exception caught in '{Settings.Scenario.StepContext.StepInfo.Text}', {ex.Message}");
                throw ex;
            }
            finally
            {
                Logger.EndStepLog(Settings.Scenario.StepContext.StepInfo.Text);
            }
        }

        [Given(@"I verify that personal information page is open and enter the request informations: Title ""(.*)"", First Name ""(.*)"", Last Name ""(.*)"", Password ""(.*)"", Address ""(.*)"", City ""(.*)"", Zip/Postal ""(.*)"", Satet ""(.*)"" country ""(.*)"" and  phone number ""(.*)""")]
        public void GivenIVerifyThatPersonalInformationPageIsOpenAndEnterTheRequestInformationsTitleFirstNameLastNamePasswordAddressCityZipPostalSatetCountryAndPhoneNumber(string title, string firstName, string lastName, string password, string address, string city, string zipPostal, string state, string country, string phone)
        {
            try
            {
                UITests _uITests = new UITests(Settings);
                _uITests.WaitForLoad();

                _uITests.TitleClick();
                _uITests.FirstName = firstName;
                _uITests.LastName = lastName;
                _uITests.Password = password;
                _uITests.Address = address;
                _uITests.City = city;
                _uITests.SetState(state);
                _uITests.ZipRegion = zipPostal;
                _uITests.SetCountry(country);
                _uITests.MobilePhone = phone;
                _uITests.SubmitAccountClick();

            }
            catch (Exception ex)
            {
                Logger.LogError($"Exception caught in '{Settings.Scenario.StepContext.StepInfo.Text}', {ex.Message}");
                throw ex;
            }
            finally
            {
                Logger.EndStepLog(Settings.Scenario.StepContext.StepInfo.Text);
            }
        }

        [Then(@"I verify the erro messagem ""(.*)""")]
        public void ThenIVerifyTheErroMessagem(string errorMessage)
        {
            try
            {
                UITests _uITests = new UITests(Settings);
                _uITests.WaitForLoad();

                Check.That(_uITests.CreateAccountError.Contains(errorMessage));

            }
            catch (Exception ex)
            {
                Logger.LogError($"Exception caught in '{Settings.Scenario.StepContext.StepInfo.Text}', {ex.Message}");
                throw ex;
            }
            finally
            {
                Logger.EndStepLog(Settings.Scenario.StepContext.StepInfo.Text);
            }
        }

        [Given(@"I enter the email ""(.*)"", Password ""(.*)"" And verify that the page loads ""(.*)"" with message ""(.*)""")]
        public void GivenIEnterTheEmailPasswordAndVerifyThatThePageLoadsWithMessage(string emailAddress, string passwordAddress, string typeMessage, string message)
        {
            try
            {
                UITests _uITests = new UITests(Settings);
                _uITests.WaitForLoad();

                if (!emailAddress.IsNullOrEmpty())
                {
                    _uITests.EmailAddess = emailAddress;
                }

                if (!passwordAddress.IsNullOrEmpty())
                {
                    _uITests.PasswordAddess = passwordAddress;
                }

                _uITests.SubmitLoginClick();

                if (typeMessage.ToLowerInvariant().Equals("error"))
                {
                    Check.That(_uITests.AlertMessage.Contains(message));
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"Exception caught in '{Settings.Scenario.StepContext.StepInfo.Text}', {ex.Message}");
                throw ex;
            }
            finally
            {
                Logger.EndStepLog(Settings.Scenario.StepContext.StepInfo.Text);
            }
        }

        [When(@"I click on Women button and search ""(.*)"" item")]
        public void WhenIClickOnWomenButtonAndSearchItem(string searchTerm)
        {
            try
            {
                UITests _uITests = new UITests(Settings);
                _uITests.WaitForLoad();

                _uITests.WomenMenuClick();
                _uITests.SearchTerm = searchTerm;
                _uITests.SearchButtonClick();
            }
            catch (Exception ex)
            {
                Logger.LogError($"Exception caught in '{Settings.Scenario.StepContext.StepInfo.Text}', {ex.Message}");
                throw ex;
            }
            finally
            {
                Logger.EndStepLog(Settings.Scenario.StepContext.StepInfo.Text);
            }
        }

        [When(@"I select a T-shit in Stock and Add to cart")]
        public void WhenISelectAT_ShitInStockAndAddToCart()
        {
            try
            {
                UITests _uITests = new UITests(Settings);
                _uITests.WaitForLoad();

                _uITests.AddCartClick();
            }
            catch (Exception ex)
            {
                Logger.LogError($"Exception caught in '{Settings.Scenario.StepContext.StepInfo.Text}', {ex.Message}");
                throw ex;
            }
            finally
            {
                Logger.EndStepLog(Settings.Scenario.StepContext.StepInfo.Text);
            }
        }

        [When(@"I go to cart item and click to remove the product from my cart")]
        public void WhenIGoToCartItemAndClickToRemoveTheProductFromMyCart()
        {
            try
            {
                UITests _uITests = new UITests(Settings);
                _uITests.WaitForLoad();

                _uITests.RemoveCartitemClick();

            }
            catch (Exception ex)
            {
                Logger.LogError($"Exception caught in '{Settings.Scenario.StepContext.StepInfo.Text}', {ex.Message}");
                throw ex;
            }
            finally
            {
                Logger.EndStepLog(Settings.Scenario.StepContext.StepInfo.Text);
            }
        }


    }


}
