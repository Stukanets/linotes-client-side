using Kpi.Linotes.ClientTests.Model.Platform.Element;

namespace Kpi.Linotes.ClientTests.Model.Platform.WebElements
{
    public interface IHtmlTextElement : IHtmlElement
    {
        void SetText(string text);

        string GetValue();

        string GetPlaceholder();
    }
}
