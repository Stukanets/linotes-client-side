using System.Collections.Generic;

namespace Kpi.Linotes.ClientTests.Model.Platform.Element
{
    public interface ISearchable
    {
        TElement Find<TElement>(Locator.Locator locator) 
            where TElement : IHtmlElement, new();

        IEnumerable<TElement> FindAll<TElement>(Locator.Locator locator) 
            where TElement : IHtmlElement, new();
    }
}
