using Kpi.Linotes.ClientTests.Model.Domain.UserInfo;
using Kpi.Linotes.ClientTests.Model.Platform.Drivers;
using Kpi.Linotes.ClientTests.Platform.Configuration.Environment;
using Kpi.Linotes.ClientTests.Platform.Factory;

namespace Kpi.Linotes.ClientTests.UI.Notes
{
    public class UserInfoSteps : StepsBase, IUserInfoSteps
    {
        public UserInfoSteps(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
            : base(webDriver, environmentConfiguration)
        {
        }

        private NotesPage NotesPage => 
            PageFactory.Get<NotesPage>(WebDriver);

        public string GetUserLogin()
        {
            return NotesPage.LeftBar.UserLogin.GetText().Trim();
        }
    }
}
