using Kpi.Linotes.ClientTests.Model.Domain.Main;

namespace Kpi.Linotes.ClientTests.Domain.Login
{
    public class LoginContext : ILoginContext
    {
        private readonly ILoginSteps _loginSteps;

        public LoginContext (
            ILoginSteps loginSteps)
        {
            _loginSteps = loginSteps;
        }

        public void OpenAndLogin (UserInformation user)
        {
            _loginSteps.OpenMainView();
            Login(user);
        }

        private void Login (UserInformation user)
        {
            _loginSteps.SetEmail(user.Login);
            _loginSteps.SetPassword(user.Password);
            _loginSteps.Login();
        }
    }
}
