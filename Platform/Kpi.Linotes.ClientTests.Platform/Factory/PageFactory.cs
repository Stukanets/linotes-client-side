using System;
using Kpi.Linotes.ClientTests.Model.Platform.Drivers;
using Kpi.Linotes.ClientTests.Model.Platform.Page;
using Kpi.Linotes.ClientTests.Platform.Element;

namespace Kpi.Linotes.ClientTests.Platform.Factory
{
    public static class PageFactory
    {
        public static TPage Get<TPage>(IWebDriver driver) 
            where TPage : IWebPage
        {
            IWebPage page = (TPage)Activator.CreateInstance(typeof(TPage), driver);
            InitPage(page);
            return (TPage)page;
        }

        private static void InitPage(IWebPage page)
        {
            if (page.GetType().HasUrlAttribute())
            {
                page.Address = page.GetType().GetUrlAttribute().Url;
            }

            ElementFactory.InitProperties(page);
        }
    }
}
