using Kpi.Linotes.ClientTests.Model.Platform.Locator;
using Kpi.Linotes.ClientTests.Platform.Element;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Linotes.ClientTests.Platform.WebElements.Dropdowns
{
    public class SelectDropdown : HtmlElement
    {
        [FindBy(How.XPath, ".//et-deposit-payment-method-dropdown")]
        public MethodDropDown MethodDropDown { get; set; }
    }
}
