namespace Kpi.Linotes.ClientTests.Model.Domain.Main
{
    public interface ILoginSteps
    {
        void SetEmail (string email);

        void SetPassword (string password);

        void Login ();

        void OpenMainView ();
    }
}
