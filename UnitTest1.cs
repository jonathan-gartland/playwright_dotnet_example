using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Threading;
using Microsoft.Playwright.Core;
using Microsoft.Playwright.TestAdapter;


namespace PlaywrightTests;

[TestClass]
public class UnitTest1 : PageTest
{
    [TestInitialize]
    // public async Task Setup()
    // {
    //     await Page.GotoAsync("https://jonathan-gartland.github.io/practice-pages");
    // }

    [TestMethod]
    public async Task MpnAppTitleTest()
    {
        await Page.GotoAsync("https://jonathan-gartland.github.io/practice-pages");
        var pageTitle = Page.Locator("text=MPN Lookup For QuantiTray\u00ae Product Suite");
        await Expect(pageTitle).ToBeVisibleAsync();

    }
    
    [TestMethod]
    public async Task MpnAppAboutTest()
    {
        await Page.GotoAsync("https://jonathan-gartland.github.io/practice-pages");
        await Expect(Page).ToHaveURLAsync(new Regex(".*practice-pages"));

    }
}
