using Kpi.Linotes.ClientTests.Model.Platform.Locator;
using Kpi.Linotes.ClientTests.Platform.Element;
using Kpi.Linotes.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Linotes.ClientTests.UI.Main
{
    public class LoginFormElement : HtmlElement
    {
        [FindBy(How.XPath, "//input[@id='user_login']")]
        public HtmlTextBox LoginTextBox { get; set; }

        [FindBy(How.XPath, "//input[@id='user_pass']")]
        public HtmlTextBox PasswordTextBox { get; set; }

        [FindBy(How.XPath, "//input[@id='wp-submit']")]
        public HtmlButton LoginButton { get; set; }
    }
}
