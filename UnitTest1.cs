using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.Playwright.MSTest;
using PlaywrightTests.PageObjects;
using Microsoft.Playwright.Core;

namespace PlaywrightTests;

[TestClass]
public class UnitTest1 : PageTest
{
  [TestMethod]
  public async Task MpnAppTitleTest() {
    var page = new MpnPage(await Browser.NewPageAsync());
    await page.GotoAsync();
    await page.inputValueAsync("22");

    var pageTitle = page.getPageTitleText();
    
  }

  [TestMethod]
  public async Task MpnAppAboutTest() {
    await Page.GotoAsync("https://jonathan-gartland.github.io/practice-pages");
    await Expect(Page).ToHaveURLAsync(new Regex(".*practice-pages"));
  }
  
  // [TestMethod]
  // public async Task MpnTest() {
  //   await Page.GotoAsync("https://jonathan-gartland.github.io/practice-pages");
  //   await Expect(Page).ToHaveURLAsync(new Regex(".*practice-pages"));
  // }
}