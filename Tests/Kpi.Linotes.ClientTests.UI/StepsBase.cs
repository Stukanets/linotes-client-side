using Kpi.Linotes.ClientTests.Model.Platform.Drivers;
using Kpi.Linotes.ClientTests.Platform.Configuration.Environment;

namespace Kpi.Linotes.ClientTests.UI
{
    public class StepsBase
    {
        private protected readonly IWebDriver WebDriver;
        private readonly IEnvironmentConfiguration _environmentConfiguration;

        protected StepsBase(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
        {
            WebDriver = webDriver;
            _environmentConfiguration = environmentConfiguration;
        }

        public void OpenMainView() =>
            WebDriver.Get(_environmentConfiguration.EnvironmentUri);
    }
}
