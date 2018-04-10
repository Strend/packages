using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SlotokingUIAuto
{
    class Profile_AccountPage : ProfilePage 
    {
        public IWebElement NameTextBox
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='Players_name']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='Players_name']"));
            }
        }

        public IWebElement SurnameTextBox
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='Players_surname']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='Players_surname']"));
            }
        }

        public IWebElement NicknameTextBox
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='Players_nickname']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='Players_nickname']"));
            }
        }

        public IWebElement MaleGenderRadioButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='Players_gender_id_0-styler']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='Players_gender_id_0-styler']"));
            }
        }

        public IWebElement DaySelectBox
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='Players_birth_day-styler']/div[1]"));                
                return Driver.Browser.FindElement(By.XPath("//*[@id='Players_birth_day-styler']/div[1]"));
            }

        }

        public IWebElement MonthSelectBox
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='Players_birth_month-styler']/div[1]/div[1]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='Players_birth_month-styler']/div[1]/div[1]"));
            }
        }

        public IWebElement YearSelectBox
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='Players_birth_year-styler']/div[1]/div[1]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='Players_birth_year-styler']/div[1]/div[1]"));
            }
        }

        public IWebElement SaveTitleButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='profile-form']/div/div/div[3]/div[1]/div/button"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='profile-form']/div/div/div[3]/div[1]/div/button"));
            }
        }

        public IWebElement SavePhoneButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='profile-form']/div/div/div[5]/div[1]/div/div[3]/div[2]/button"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='profile-form']/div/div/div[5]/div[1]/div/div[3]/div[2]/button"));
            }
        }

        public IWebElement SavePersonalInfoButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='profile-form']/div/div/div[3]/div[2]/div/button"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='profile-form']/div/div/div[3]/div[2]/div/button"));
            }
        }        

        public IWebElement PlayerPhoneTextBox
        {
            get
            {
                Driver.WaitUntil(By.Id("Players_phone"));
                return Driver.Browser.FindElement(By.Id("Players_phone"));
            }
        }

        public IWebElement CountryListBox
        {
            get
            {
                Driver.WaitUntil(By.ClassName("jq-selectbox__select"));
                return Driver.Browser.FindElement(By.ClassName("jq-selectbox__select"));
            }
        }

        public IWebElement UkraineyListBoxElement
        {
            get
            {
                Driver.WaitUntil(By.XPath(" //*[@id='Players_country_id-styler']/div[2]/ul/li[6]"));
                return Driver.Browser.FindElement(By.XPath(" //*[@id='Players_country_id-styler']/div[2]/ul/li[6]"));
            }
        }

        public IWebElement CityTextBox
        {
            get
            {
                Driver.WaitUntil(By.Id("Players_city"));
                return Driver.Browser.FindElement(By.Id("Players_city"));
            }
        }

        public IWebElement AddressListBox
        {
            get
            {
                Driver.WaitUntil(By.Id(" Players_address"));
                return Driver.Browser.FindElement(By.Id("Players_address"));
            }
        }       

        public void FillDate()
        {
            DaySelectBox.Click();
            Driver.Browser.FindElement(By.XPath("//*[@id='Players_birth_day-styler']/div[2]/ul/li[3]")).Click();
            
            MonthSelectBox.Click();
            Driver.Browser.FindElement(By.XPath("//*[@id='Players_birth_month-styler']/div[2]/ul/li[5]")).Click();
           
            YearSelectBox.Click();
            Driver.Browser.FindElement(By.XPath("//*[@id='Players_birth_year-styler']/div[2]/ul/li[4]")).Click();            
        }

        public void ChooseCountry()
        {
            CountryListBox.Click();
            UkraineyListBoxElement.Click();
        }


    }
}
