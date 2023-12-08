using System.Text.RegularExpressions;
using System.Collections.Generic;
using Microsoft.Playwright.MSTest;
using Newtonsoft.Json;

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
  public async Task QtValTest() {
    string json = @"{""0"":""0"", ""22"":""19"", ""51"":""146.1""}";
    var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(json)!;
    var page = await Browser.NewPageAsync();
    _mpnPage = new MpnPage(page);
    await _mpnPage.GotoAsync();

    foreach (KeyValuePair<string, string> val in values)
    {
      await _mpnPage.UpdateInputQt(val.Key);
      var text = await _mpnPage.MpnValue();
      Assert.AreEqual(text, val.Value);
    }
  }
}