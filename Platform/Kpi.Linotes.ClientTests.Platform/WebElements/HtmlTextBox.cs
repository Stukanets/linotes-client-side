using Kpi.Linotes.ClientTests.Model.Platform.WebElements;
using Kpi.Linotes.ClientTests.Platform.Element;

namespace Kpi.Linotes.ClientTests.Platform.WebElements
{
    public class HtmlTextBox : HtmlElement, IHtmlTextElement
    {
        public void SetText(string text)
        {
            NativeElement.Clear();
            NativeElement.SendKeys(text);
        }

        public string GetValue() => NativeElement.GetAttribute("value");

        public string GetPlaceholder() => NativeElement.GetAttribute("placeholder");
    }
}
