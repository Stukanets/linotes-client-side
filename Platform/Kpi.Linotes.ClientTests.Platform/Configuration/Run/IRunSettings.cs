using Kpi.Linotes.ClientTests.Model.Domain.Run;

namespace Kpi.Linotes.ClientTests.Platform.Configuration.Run
{
    public interface IRunSettings
    {
        SeleniumGrid SeleniumGrid { get; set; }

        RunType RunType { get; set; }
    }
}
