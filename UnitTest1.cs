using System.Text.RegularExpressions;
using Microsoft.Playwright.MSTest;

namespace PlaywrightTests;

[TestClass]
public class UnitTest1 : PageTest
{
  private MpnPage _mpnPage = null!;
  
  [TestMethod]
  public async Task LinkToInfoWorksTest() {
    var page = await Browser.NewPageAsync();
    _mpnPage = new MpnPage(page);
    await _mpnPage.GotoAsync();
    await _mpnPage.ClickQtInfoLink();
    var leftPage = await _mpnPage.LeftPageWithQtInfoLink();
    Assert.IsTrue(leftPage);
  }
  
  [TestMethod]
  public async Task LinkToMpnGenWorksTest() {
    var page = await Browser.NewPageAsync();
    _mpnPage = new MpnPage(page);
    await _mpnPage.GotoAsync();
    await _mpnPage.ClickMpnGenLink();
    var leftPage = await _mpnPage.LeftPageWithMpnGenLink();
    Assert.IsTrue(leftPage);
  }
  
  [TestMethod]
  public async Task MpnAppAboutTest() {
    var page = await Browser.NewPageAsync();
    _mpnPage = new MpnPage(page);
    await _mpnPage.GotoAsync();
    var mpnVisible = await _mpnPage.IsMpnValDisplayed();
    Assert.IsTrue(mpnVisible);

  }
  
  [TestMethod]
  public async Task MpnTest() {
    var page = await Browser.NewPageAsync();
    _mpnPage = new MpnPage(page);
    await _mpnPage.GotoAsync();
    var text = await _mpnPage.MpnValue();
    // it's zero, so easy test, need to encapsulate in loop
    // to test a few random values
    Assert.AreEqual(text, "0");
  }
}