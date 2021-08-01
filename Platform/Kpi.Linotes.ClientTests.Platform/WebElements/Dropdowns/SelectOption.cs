using Kpi.Linotes.ClientTests.Model.Platform.Locator;
using Kpi.Linotes.ClientTests.Platform.Element;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Linotes.ClientTests.Platform.WebElements.Dropdowns
{
    public class SelectOption : HtmlElement
    {
        [FindBy(How.XPath, ".//span")]
        public HtmlLabel Name { get; set; }
    }
}
