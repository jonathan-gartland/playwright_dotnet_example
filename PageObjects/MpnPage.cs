using System.Threading.Tasks;
using Microsoft.Playwright;

namespace PlaywrightTests.PageObjects;

public class MpnPage
{
    private readonly IPage _page;
    private readonly ILocator _mpnPageTitle;
    
    public MpnPage(IPage page)
    {
        _page = page;
        _mpnPageTitle = page.Locator("[data-testid='mpn-lookup-title']");
    }

    public async Task GotoAsync()
    {
        await _page.GotoAsync("https://jonathan-gartland.github.io/practice-pages");
    }

    public async Task FindTitleAsync()
    {
        await _mpnPageTitle.IsVisibleAsync();
    }
    
    

}