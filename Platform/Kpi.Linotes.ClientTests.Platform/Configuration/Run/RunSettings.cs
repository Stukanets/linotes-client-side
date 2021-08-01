using Kpi.Linotes.ClientTests.Model.Domain.Run;

namespace Kpi.Linotes.ClientTests.Platform.Configuration.Run
{
    public class RunSettings : IRunSettings
    {
        public SeleniumGrid SeleniumGrid { get; set; }

        public RunType RunType { get; set; }
    }
}
