using Kpi.Linotes.ClientTests.Model.Platform.WebElements;
using Kpi.Linotes.ClientTests.Platform.Element;

namespace Kpi.Linotes.ClientTests.Platform.WebElements
{
    public class HtmlLink : HtmlElement, IHtmlLink
    {
        public string GetLink() => GetAttribute("href");

        public new void Click() => base.Click();
    }
}
