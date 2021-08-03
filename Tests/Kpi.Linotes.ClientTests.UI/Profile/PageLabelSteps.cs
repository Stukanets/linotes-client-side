using Kpi.Linotes.ClientTests.Model.Domain.Profile;
using Kpi.Linotes.ClientTests.Model.Platform.Drivers;
using Kpi.Linotes.ClientTests.Platform.Configuration.Environment;
using Kpi.Linotes.ClientTests.Platform.Factory;

namespace Kpi.Linotes.ClientTests.UI.Profile
{
    public class PageLabelSteps : StepsBase, IPageLabelSteps
    {
        public PageLabelSteps(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
            : base(webDriver, environmentConfiguration)
        {
        }

        private ProfilePage ProfilePage => 
            PageFactory.Get<ProfilePage>(WebDriver);

        public string GetPageLabel()
        {
            return ProfilePage.Label.GetText().Trim();
        }
    }
}
