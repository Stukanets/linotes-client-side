using Kpi.Linotes.ClientTests.Model.Platform.Locator;
using Kpi.Linotes.ClientTests.Platform.Element;
using Kpi.Linotes.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Linotes.ClientTests.UI.Notes
{
    public class HeadMenuElement : HtmlElement
    {
        [FindBy(How.XPath, "//div/ul/li[2]/a")]
        public HtmlButton CabinetButton { get; set; }
    }
}
