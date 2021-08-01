using Kpi.Linotes.ClientTests.Model.Platform.Drivers;
using Kpi.Linotes.ClientTests.Model.Platform.Locator;
using Kpi.Linotes.ClientTests.Platform.Page;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Linotes.ClientTests.UI.Main
{
    public class MainPage : WebPage
    {
        public MainPage(IWebDriver webDriver) 
            : base(webDriver)
        {
        }

        [FindBy(How.XPath, "//*[@id='loginform']")]
        public LoginFormElement LoginForm { get; set; }
    }
}
