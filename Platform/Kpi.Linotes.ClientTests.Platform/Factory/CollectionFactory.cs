using System;
using Kpi.Linotes.ClientTests.Model.Platform.Element;
using Kpi.Linotes.ClientTests.Model.Platform.Locator;
using Kpi.Linotes.ClientTests.Platform.Element;

namespace Kpi.Linotes.ClientTests.Platform.Factory
{
    internal static class CollectionFactory
    {
        internal static IHtmlElementsCollection<THtmlElement> Create<THtmlElement>(
            INative parent,
            Locator locator)
            where THtmlElement : IHtmlElement, new() =>
                new HtmlElementsCollection<THtmlElement>(parent, locator);

        internal static object Create(Type type, INative parent, Locator locator)
        {
            var concreteType = typeof(HtmlElementsCollection<>)
                .MakeGenericType(type.GetGenericArguments());
            return Activator.CreateInstance(concreteType, parent, locator);
        }
    }
}
