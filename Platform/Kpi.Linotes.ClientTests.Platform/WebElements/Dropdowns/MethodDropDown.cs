using System;
using System.Linq;
using Kpi.Linotes.ClientTests.Model.Platform.Locator;
using Kpi.Linotes.ClientTests.Model.Platform.WebElements.Dropdowns;
using Kpi.Linotes.ClientTests.Platform.Element;
using Kpi.Linotes.ClientTests.Platform.Waiter;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Linotes.ClientTests.Platform.WebElements.Dropdowns
{
    public class MethodDropDown : HtmlElement, IMethodDropdown
    {
        [FindBy(How.XPath, ".//et-select")] 
        private HtmlButton SelectButton { get; set; }

        [FindBy(How.XPath, ".//et-select-body")]
        private SelectBody SelectBody { get; set; }

        public void OpenDropdown()
        {
            SelectButton.Click();
            WaitFor.Condition(() => SelectBody.GetDisplayed(), "Dropdown wasn't opened", TimeSpan.FromSeconds(30));
        }

        public void Select(string value) =>
            SelectBody.SelectOptions
                .Single(i => i.Name.GetText().Trim().Equals(value))
                .Click();

        public string[] GetOptions() =>
            SelectBody.SelectOptions.Select(i => i.Name.GetText().Trim())
                .ToArray();
    }
}
