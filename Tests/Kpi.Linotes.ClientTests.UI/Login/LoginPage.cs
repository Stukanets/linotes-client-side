using Kpi.Linotes.ClientTests.Model.Platform.Drivers;
using Kpi.Linotes.ClientTests.Model.Platform.Locator;
using Kpi.Linotes.ClientTests.Platform.Page;
using Kpi.Linotes.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Linotes.ClientTests.UI.Login
{
    public class LoginPage : WebPage
    {
        public LoginPage(IWebDriver webDriver)
            : base(webDriver)
        {
        }

        [FindBy(How.XPath, "//*[@id='login_error']/strong")]
        public HtmlLabel ErrorMessage { get; set; }
    }
}
