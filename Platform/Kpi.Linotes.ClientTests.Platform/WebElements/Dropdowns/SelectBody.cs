using System.Linq;
using Kpi.Linotes.ClientTests.Model.Platform.Locator;
using Kpi.Linotes.ClientTests.Platform.Element;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Linotes.ClientTests.Platform.WebElements.Dropdowns
{
    public class SelectBody : HtmlElement
    {
        public SelectOption[] SelectOptions =>
            FindAll<SelectOption>(new Locator(How.XPath, ".//et-select-body-option"))
                .ToArray();
    }
}
