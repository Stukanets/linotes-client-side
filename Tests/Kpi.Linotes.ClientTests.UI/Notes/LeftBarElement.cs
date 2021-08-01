using Kpi.Linotes.ClientTests.Model.Platform.Locator;
using Kpi.Linotes.ClientTests.Platform.Element;
using Kpi.Linotes.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Linotes.ClientTests.UI.Notes
{
    public class LeftBarElement : HtmlElement
    {
        [FindBy(How.XPath, "//div[@class='user_login']/a")]
        public HtmlLabel UserLogin { get; set; }
    }
}
