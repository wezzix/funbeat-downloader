using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using SimpleBrowser;

namespace MK.Funbeat
{
    public class FunbeatTrainingScraper
    {
        private Browser _driver;

        public void ScrapeTrainings(
            IEnumerable<RawTraining> trainings, AuthenticationParameters authenticationParameters)
        {
            try
            {
                _driver = new Browser();

                Login(authenticationParameters);

                trainings.ToList().ForEach(ParseTraining);
            }
            finally
            {
                _driver.Close();
            }
        }

        private void Login(AuthenticationParameters authenticationParameters)
        {
            _driver.UserAgent =
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.224 Safari/534.10";
            _driver.Navigate("http://www.funbeat.se/");

            _driver.Find("UsernameTextBox").Value = authenticationParameters.Username;
            _driver.Find("ctl00_ParallaxContentPlaceHolder_Login1_PasswordTextBox").Value =
                authenticationParameters.Password;
            _driver.Find("ctl00_ParallaxContentPlaceHolder_Login1_LoginButton").Click();
        }

        private void ParseTraining(RawTraining rawTraining)
        {
            var url = string.Format(
                "http://www.funbeat.se/training/edit.aspx?Return=calendar&TrainingID={0}", rawTraining.Id);
            _driver.Navigate(url);
            rawTraining.Data = GetJsonDataFromSource(_driver.CurrentHtml);
        }

        private static string GetJsonDataFromSource(string source)
        {
            var match = Regex.Match(
                source, @"var\s*TrainingEditData\s*=\s*{\s*Training:\s*(.*)\s*,\s*DayNote:", RegexOptions.Singleline);
            var value = match.Success
                ? match.Groups[1].Value
                : null;
            return value;
        }
    }

    public class AuthenticationParameters
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}