using Kpi.Linotes.ClientTests.Model.Platform.Element;
using Kpi.Linotes.ClientTests.Platform.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using IWebDriver = Kpi.Linotes.ClientTests.Model.Platform.Drivers.IWebDriver;

namespace Kpi.Linotes.ClientTests.Platform.Element
{
    public static class ElementExtensions
    {
        public static void ScrollDown(this HtmlElement nativeElement, IWebDriver webDriver) =>
            new Actions(((WebDriver)webDriver).GetNativeDriver())
                .SendKeys(((IHtmlElement)nativeElement).GetNativeElement(), Keys.End)
                .Perform();

        public static void ScrollUp(this HtmlElement nativeElement, IWebDriver webDriver) =>
            new Actions(((WebDriver)webDriver).GetNativeDriver())
                .SendKeys(((IHtmlElement)nativeElement).GetNativeElement(), Keys.Up)
                .Perform();
    }
}
