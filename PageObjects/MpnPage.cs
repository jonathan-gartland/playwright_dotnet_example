namespace PlaywrightTests.PageObjects;

public class MpnPage 
{
  // private IReporter _reporter; 
  private readonly IPage _page;

  public MpnPage(IPage page) {
    _page = page;
  }
  private ILocator _MpnPageTitleHeader => _page.Locator("[data-testid='mpn-lookup-title']");
  private ILocator _QuantiTrayInfoLink => _page.Locator("[data-testid='qtlink']");
  private ILocator _QtInfoPageElement => _page.Locator("#page-top > header > div.header-top-menu > div > div.navbar-brand > a");
  private ILocator _MpnGenPageTextHeader => _page.Locator("#page-top > div.page-content > div > div:nth-child(1) > div:nth-child(2) > h1");
  // private ILocator _getQt2KPdfLink => _page.Locator("#aboutdiv > div > a:nth-child(14)");
  private ILocator _getMpnGeneratorLink => _page.Locator("#aboutdiv > div > a:nth-child(18)");
  private ILocator _QtInput => _page.Locator("[data-testid='qt-input-dataid']");
  // private ILocator _Qt2KInputL => _page.Locator("[id='qt2klinput']");
  // private ILocator _Qt2KInputLS=> _page.Locator("[id='qt2ksinput']");
  // private ILocator qtLegioInputL=> _page.Locator();
  // private ILocator qtLegioInputS => _page.Locator();
  private ILocator _QtMpnVal => _page.Locator("[data-testid='qt-mpn-val']");
  // private ILocator _Qt2KMpnVal => _page.Locator("[id='qt2k-mpn-val']");
  // private ILocator _QtLegioMpnVal => _page.Locator("[id='qtl-mpn-val']");
  
  public async Task GotoAsync() {
    await _page.GotoAsync("https://jonathan-gartland.github.io/practice-pages");
  }
  public async Task ClickQtInfoLink() {
    await _QuantiTrayInfoLink.ClickAsync();
    await _page.WaitForTimeoutAsync(2000); // 
  }
  public async Task ClickMpnGenLink() {
    await _QuantiTrayInfoLink.ClickAsync();
    await _page.WaitForTimeoutAsync(2000); // 
  }

  public async Task<bool> LeftPageWithQtInfoLink() {
    return await _QtInfoPageElement.IsVisibleAsync();
  }
  public async Task<bool> LeftPageWithMpnGenLink() {
    return await _MpnGenPageTextHeader.IsVisibleAsync();
  }
  public async Task<bool> IsMpnValDisplayed() {
    return await _QtMpnVal.IsVisibleAsync();
  }
  public async Task<string> MpnValue() {
    var strsplit = await _QtMpnVal.InnerTextAsync();
    var val = strsplit.Split(":")[1].TrimStart();
    return val;
  }

  public async Task UpdateInputQt(string inPos) {
    await _QtInput.FillAsync(inPos);
  }
  
}