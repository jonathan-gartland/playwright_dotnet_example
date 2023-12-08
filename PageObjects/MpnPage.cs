namespace PlaywrightTests.PageObjects;

public class MpnPage 
{
  // private IReporter _reporter; // started toi implement out of habit, but this demo doesn't need reporting yet
  private readonly IPage _page;

  public MpnPage(IPage page) {
    _page = page;
  }
  private ILocator _mpnPageTitleHeader => _page.Locator("[data-testid='mpn-lookup-title']");
  private ILocator _quantiTrayInfoLink => _page.Locator("[data-testid='qtlink']");
  private ILocator _qtInfoPageElement => _page.Locator("#page-top > header > div.header-top-menu > div > div.navbar-brand > a");
  private ILocator _mpnGenPageTextHeader => _page.Locator("#page-top > div.page-content > div > div:nth-child(1) > div:nth-child(2) > h1");
  // private ILocator _getQt2KPdfLink => _page.Locator("#aboutdiv > div > a:nth-child(14)");
  private ILocator _getMpnGeneratorLink => _page.Locator("#aboutdiv > div > a:nth-child(18)");

  private ILocator _qtInput => _page.Locator("[data-testid='qt-input-dataid']");
  // private ILocator _qt2KInputL => _page.Locator("[id='qt2klinput']");
  // private ILocator _qt2KInputLS=> _page.Locator("[id='qt2ksinput']");
  // private ILocator qtLegioInputL=> _page.Locator();
  // private ILocator qtLegioInputS => _page.Locator();
  private ILocator _qtMpnVal => _page.Locator("[data-testid='qt-mpn-val']");
  // private ILocator _qt2KMpnVal => _page.Locator("[id='qt2k-mpn-val']");
  // private ILocator _qtLegioMpnVal => _page.Locator("[id='qtl-mpn-val']");
  
  
  
  public async Task GotoAsync() {
    await _page.GotoAsync("https://jonathan-gartland.github.io/practice-pages");
  }
  

  public async Task ClickQtInfoLink() {
    await _quantiTrayInfoLink.ClickAsync();
    await _page.WaitForTimeoutAsync(2000); // 
  }
  
  // public async Task ClickQt2KPdfLink() {
  //   await _getQt2KPdfLink.ClickAsync();
  //   await _page.WaitForTimeoutAsync(2000); // 
  // }
  
  public async Task ClickMpnGenLink() {
    await _quantiTrayInfoLink.ClickAsync();
    await _page.WaitForTimeoutAsync(2000); // 
  }

  public async Task<bool> LeftPageWithQtInfoLink() {
    return await _qtInfoPageElement.IsVisibleAsync();
  }
  // public async Task<bool> LeftPageWithQt2KLink() {
  //   //return await .IsVisibleAsync();
  // }
  
  public async Task<bool> LeftPageWithMpnGenLink() {
    return await _mpnGenPageTextHeader.IsVisibleAsync();
  }

  public async Task<bool> IsMpnValDisplayed() {

    // await _qtInput.FillAsync(posWells);
    return await _qtMpnVal.IsVisibleAsync();
  }

  public async Task<string> MpnValue() {
    var strsplit = await _qtMpnVal.InnerTextAsync();
    var val = strsplit.Split(":")[1];
    return val;
  }
}