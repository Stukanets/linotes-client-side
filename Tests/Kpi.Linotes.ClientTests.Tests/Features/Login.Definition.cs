using FluentAssertions;
using Kpi.Linotes.ClientTests.Model.Domain.Login;
using Kpi.Linotes.ClientTests.Model.Domain.Main;
using Kpi.Linotes.ClientTests.Model.Domain.UserInfo;
using Kpi.Linotes.ClientTests.TestsData.Storage;
using TechTalk.SpecFlow;

namespace Kpi.Linotes.ClientTests.Tests.Features
{
    [Binding, Scope(Feature = "Login")]
    public class LoginDefinition
    {
        private readonly ILoginContext _loginContext;
        private readonly IUserInfoSteps _userInfoSteps;
        private readonly IGetErrorSteps _getErrorSteps;
        private UserInformation _userInformation;

        public LoginDefinition(
            ILoginContext loginContext, 
            IUserInfoSteps userInfoSteps,
            IGetErrorSteps getErrorSteps)
        {
            _loginContext = loginContext;
            _userInfoSteps = userInfoSteps;
            _getErrorSteps = getErrorSteps;
        }

        [Given(@"I have (.*) user")]
        public void GivenIHaveExistingUserUser(string entityName)
        {
            _userInformation = UsersStorage.Users[entityName];
        }

        [When(@"I login to application")]
        public void WhenILoginToApplication()
        {
            _loginContext.OpenAndLogin(_userInformation);
        }

        [Then(@"I see user login '(.*)' in left bar")]
        public void ThenISeeUserLoginInLeftBar(string login)
        {
            _userInfoSteps.GetUserLogin().Should()
                .BeEquivalentTo(login);
        }

        [Then(@"I see '(.*)' message")]
        public void ThenISeeMessageInForm(string message)
        {
            _getErrorSteps.GetErrorMessage().Should().BeEquivalentTo(message);
        }
    }
}