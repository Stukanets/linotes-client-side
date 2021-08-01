using System;
using Autofac;
using Kpi.Linotes.ClientTests.Domain.Login;
using Kpi.Linotes.ClientTests.Model.Domain.Login;
using Kpi.Linotes.ClientTests.Model.Domain.Main;
using Kpi.Linotes.ClientTests.Model.Domain.Notes;
using Kpi.Linotes.ClientTests.Model.Domain.Profile;
using Kpi.Linotes.ClientTests.Model.Domain.UserInfo;
using Kpi.Linotes.ClientTests.Model.Platform.Communication;
using Kpi.Linotes.ClientTests.Platform.Communication;
using Kpi.Linotes.ClientTests.Platform.Configuration.Environment;
using Kpi.Linotes.ClientTests.Platform.Configuration.Run;
using Kpi.Linotes.ClientTests.Platform.Driver;
using Kpi.Linotes.ClientTests.UI.Login;
using Kpi.Linotes.ClientTests.UI.Main;
using Kpi.Linotes.ClientTests.UI.Notes;
using Kpi.Linotes.ClientTests.UI.Profile;
using Microsoft.Extensions.Configuration;
using RestSharp;
using Serilog;
using Serilog.Events;
using IWebDriver = Kpi.Linotes.ClientTests.Model.Platform.Drivers.IWebDriver;

namespace Kpi.Linotes.ClientTests.Bootstrap
{
    public class Bootstraper
    {
        private ContainerBuilder _builder;

        public ContainerBuilder Builder => _builder ??= new ContainerBuilder();

        public void ConfigureServices(IConfigurationBuilder configurationBuilder)
        {
            var configurationRoot = configurationBuilder.Build();
            Builder.Register<ILogger>((c, p) => new LoggerConfiguration()
                .WriteTo.File(
                    $"Logs/log_{DateTime.UtcNow:yyyy_MM_dd_hh_mm_ss}.txt",
                    LogEventLevel.Verbose,
                    "{Timestamp:dd-MM-yyyy HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger())
                .SingleInstance();

            // Configurations
            Builder.Register<IEnvironmentConfiguration>(context => configurationRoot.Get<EnvironmentConfiguration>())
                .SingleInstance();
            Builder.Register<IRunSettings>(cont => configurationRoot.Get<RunSettings>())
                .SingleInstance();

            Builder.RegisterType<Client>().As<IClient>().InstancePerDependency();
            Builder.RegisterType<RestClient>().As<IRestClient>().InstancePerDependency();

            // Logic
            Builder.RegisterType<LoginContext>().As<ILoginContext>().SingleInstance();
            Builder.RegisterType<LoginSteps>().As<ILoginSteps>().SingleInstance();
            Builder.RegisterType<GetErrorSteps>().As<IGetErrorSteps>().SingleInstance();
            Builder.RegisterType<UserInfoSteps>().As<IUserInfoSteps>().SingleInstance();
            Builder.RegisterType<PageLabelSteps>().As<IPageLabelSteps>().SingleInstance();
            Builder.RegisterType<OpenProfileSteps>().As<IOpenProfileSteps>().SingleInstance();

            Builder.RegisterType<WebDriver>().As<IWebDriver>().SingleInstance();
        }
    }
}
