using Kpi.Linotes.ClientTests.Model.Platform.Drivers;
using Kpi.Linotes.ClientTests.Model.Platform.Locator;
using Kpi.Linotes.ClientTests.Platform.Page;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Linotes.ClientTests.UI.Notes
{
    public class NotesPage : WebPage
    {
        public NotesPage(IWebDriver webDriver)
            : base(webDriver)
        {
        }

        [FindBy(How.XPath, "//*[@id='left-component']")]
        public LeftBarElement LeftBar { get; set; }

        [FindBy(How.XPath, "//*[@id='block_nav']")]
        public HeadMenuElement HeadMenu { get; set; }
    }
}
