using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Threading;
using Microsoft.Playwright.Core;
using Microsoft.Playwright.TestAdapter;
using PlaywrightTests.PageObjects;
using System;


namespace PlaywrightTests;

[TestClass]
public class UnitTest1 : PageTest
{
    [TestMethod]
    public async Task MpnAppTitleTest()
    {
        var page = new MpnPage(await Browser.NewPageAsync() );
        await page.GotoAsync();
        var pageTitle = page.FindTitleAsync();
  
        Console.WriteLine($"hello console!");

        System.Diagnostics.Debug.WriteLine($"hello debugger!");
        // System.Diagnostics.Debug.WriteLine("XXXXX" + pageTitle.Id);
        
        // await Expect(pageTitle).ToBeVisibleAsync();

    }
    
    [TestMethod]
    public async Task MpnAppAboutTest()
    {
        await Page.GotoAsync("https://jonathan-gartland.github.io/practice-pages");
        await Expect(Page).ToHaveURLAsync(new Regex(".*practice-pages"));

    }
}
