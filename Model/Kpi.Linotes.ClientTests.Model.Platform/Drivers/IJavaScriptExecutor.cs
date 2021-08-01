namespace Kpi.Linotes.ClientTests.Model.Platform.Drivers
{
    public interface IJavaScriptExecutor
    {
        object ExecuteScript(string script, params object[] args);
    }
}
