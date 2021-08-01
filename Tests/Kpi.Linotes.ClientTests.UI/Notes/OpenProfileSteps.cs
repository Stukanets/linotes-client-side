using Kpi.Linotes.ClientTests.Model.Domain.Notes;
using Kpi.Linotes.ClientTests.Model.Platform.Drivers;
using Kpi.Linotes.ClientTests.Platform.Configuration.Environment;
using Kpi.Linotes.ClientTests.Platform.Factory;

namespace Kpi.Linotes.ClientTests.UI.Notes
{
    public class OpenProfileSteps : StepsBase, IOpenProfileSteps
    {
        public OpenProfileSteps(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
            : base(webDriver, environmentConfiguration)
        {
        }

        private NotesPage NotesPage =>
            PageFactory.Get<NotesPage>(WebDriver);

        public void OpenProfile()
        {
            NotesPage.HeadMenu.CabinetButton.Click();
        }
    }
}
