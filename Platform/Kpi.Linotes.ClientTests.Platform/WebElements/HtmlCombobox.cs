using System.Collections.Generic;
using System.Linq;
using Kpi.Linotes.ClientTests.Model.Platform.Locator;
using Kpi.Linotes.ClientTests.Model.Platform.WebElements;
using Kpi.Linotes.ClientTests.Platform.Element;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Kpi.Linotes.ClientTests.Platform.WebElements
{
    public class HtmlCombobox : HtmlElement, IHtmlCombobox
    {
        private IEnumerable<HtmlElement> Options =>
            FindAll<HtmlElement>(new Locator(How.XPath, "./option")).ToArray();

        public string GetSelected() =>
            new SelectElement(NativeElement).SelectedOption.Text;

        public string[] GetValues() =>
            Options.Select(i => i.GetText().Trim()).ToArray();

        public void Select(string value) =>
            new SelectElement(NativeElement)
                .SelectByText(value);
    }
}
