using System.Collections.Generic;

namespace Kpi.Linotes.ClientTests.Model.Platform.Element
{
    public interface IHtmlElementsCollection<out THtmlElement> : IEnumerable<THtmlElement> 
        where THtmlElement : IHtmlElement
    {
    }
}
