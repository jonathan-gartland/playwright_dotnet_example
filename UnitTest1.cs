using System.Text.RegularExpressions;
using Microsoft.Playwright.MSTest;

namespace PlaywrightTests;

[TestClass]
public class UnitTest1 : PageTest
{
  private MpnPage? _mpnPage;
  
  [TestMethod]
  public async Task LinkToInfoWorksTest() {
    _mpnPage = new MpnPage(await Browser.NewPageAsync());
    await _mpnPage.GotoAsync();
    await _mpnPage.ClickQtInfoLink();
    var leftPage = await _mpnPage.LeftPageWithQtInfoLink();
    Assert.IsTrue(leftPage);
  }
  
  // [TestMethod]
  // public async Task LinkToQt2KWorksTest() {
  //   _mpnPage = new MpnPage(await Browser.NewPageAsync());
  //   await _mpnPage.GotoAsync();
  //   await _mpnPage.ClickQt2KPdfLink();
  //   var leftPage = await _mpnPage.LeftPageWithQt2KLink();
  //   Assert.IsTrue(leftPage);
  // }
  
  [TestMethod]
  public async Task LinkToMpnGenWorksTest() {
    _mpnPage = new MpnPage(await Browser.NewPageAsync());
    await _mpnPage.GotoAsync();
    await _mpnPage.ClickMpnGenLink();
    var leftPage = await _mpnPage.LeftPageWithMpnGenLink();
    Assert.IsTrue(leftPage);
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