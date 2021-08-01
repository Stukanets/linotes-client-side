using Kpi.Linotes.ClientTests.Model.Domain.Main;
using Kpi.Linotes.ClientTests.Model.Platform.Drivers;
using Kpi.Linotes.ClientTests.Platform.Configuration.Environment;
using Kpi.Linotes.ClientTests.Platform.Factory;

namespace Kpi.Linotes.ClientTests.UI.Main
{
    public class LoginSteps : StepsBase, ILoginSteps
    {
        private readonly IWebDriver _webDriver;

        public LoginSteps (
            IWebDriver webDriver, 
            IEnvironmentConfiguration environmentConfiguration) 
            : base(webDriver, environmentConfiguration)
        {
            _webDriver = webDriver;
        }

        private MainPage MainPage => PageFactory.Get<MainPage>(_webDriver);

        public void SetEmail (string email)
        {
            MainPage.LoginForm.LoginTextBox.SetText(email);
        }

        public void SetPassword (string password)
        {
            MainPage.LoginForm.PasswordTextBox.SetText(password);
        }

        public void Login ()
        {
            MainPage.LoginForm.LoginButton.Click();
        }
    }
}
