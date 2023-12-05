using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlaywrightTests;

[TestClass]
public class UnitTest1 : PageTest
{
    [TestMethod]
    public async Task HomepageHasPlaywrightInTitleAndGetStartedLinkLinkingtoTheIntroPage()
    {

        await Page.GotoAsync("https://jonathan-gartland.github.io/practice-pages");
        await Expect(Page.Locator("text=MPN Lookup For QuantiTray\u00ae Product Suite")).ToBeVisibleAsync();

    }
}
