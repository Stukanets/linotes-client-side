using Kpi.Linotes.ClientTests.Model.Platform.Drivers;
using Kpi.Linotes.ClientTests.Platform.Configuration.Environment;

namespace Kpi.Linotes.ClientTests.UI
{
    public class StepsBase
    {
        private readonly IWebDriver _webDriver;
        private readonly IEnvironmentConfiguration _environmentConfiguration;

        protected StepsBase(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
        {
            _webDriver = webDriver;
            _environmentConfiguration = environmentConfiguration;
        }

        public void OpenMainView() =>
            _webDriver.Get(_environmentConfiguration.EnvironmentUri);
    }
}
