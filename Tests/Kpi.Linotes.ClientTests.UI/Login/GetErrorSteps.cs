using Kpi.Linotes.ClientTests.Model.Domain.Login;
using Kpi.Linotes.ClientTests.Model.Platform.Drivers;
using Kpi.Linotes.ClientTests.Platform.Configuration.Environment;
using Kpi.Linotes.ClientTests.Platform.Factory;

namespace Kpi.Linotes.ClientTests.UI.Login
{
    public class GetErrorSteps : StepsBase, IGetErrorSteps
    {
        public GetErrorSteps(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
            : base(webDriver, environmentConfiguration)
        {
        }

        private LoginPage LoginPage =>
            PageFactory.Get<LoginPage>(WebDriver);

        public string GetErrorMessage()
        {
            return LoginPage.ErrorMessage.GetText().Trim();
        }
    }
}
