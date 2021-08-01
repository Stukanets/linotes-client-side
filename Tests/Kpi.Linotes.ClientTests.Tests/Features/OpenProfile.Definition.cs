using FluentAssertions;
using Kpi.Linotes.ClientTests.Model.Domain.Main;
using Kpi.Linotes.ClientTests.Model.Domain.Notes;
using Kpi.Linotes.ClientTests.Model.Domain.Profile;
using Kpi.Linotes.ClientTests.TestsData.Storage;
using TechTalk.SpecFlow;

namespace Kpi.Linotes.ClientTests.Tests.Features
{
    [Binding, Scope(Feature = "Open Profile")]
    public class OpenProfile
    {
        private readonly ILoginContext _loginContext;
        private readonly IOpenProfileSteps _openProfileSteps;
        private readonly IPageLabelSteps _pageLabelSteps;
        private UserInformation _userInformation;

        public OpenProfile(
            ILoginContext loginContext,
            IOpenProfileSteps openProfileSteps,
            IPageLabelSteps pageLabelSteps)
        {
            _loginContext = loginContext;
            _openProfileSteps = openProfileSteps;
            _pageLabelSteps = pageLabelSteps;
        }

        [Given(@"I logged in application as (.*)")]
        public void GivenILoggedInApplication(string user)
        {
            _userInformation = UsersStorage.Users[user];
            _loginContext.OpenAndLogin(_userInformation);
        }

        [When(@"I click 'Cabinet' button")]
        public void WhenIClickCabinetButton()
        {
            _openProfileSteps.OpenProfile();
        }

        [Then(@"I see '(.*)' as title of the page")]
        public void ThenISeeAsTitleOfThePage(string title)
        {
            _pageLabelSteps.GetPageLabel().Should().BeEquivalentTo(title);
        }
    }
}
