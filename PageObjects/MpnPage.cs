using System.Runtime.InteropServices.JavaScript;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace PlaywrightTests.PageObjects;

public class MpnPage
{
    // public static string mpnPageTitle { get; set; }
    private readonly IPage _page;
    private readonly ILocator _mpnPageTitle;
    private readonly ILocator _mpnPosWellInput;
    
    public MpnPage(IPage page)
    {
        _page = page;
        _mpnPageTitle = page.Locator("[data-testid='mpn-lookup-title']");
        _mpnPosWellInput = page.Locator("[data-testid='qt-input-dataid']");
    }

    public async Task GotoAsync()
    {
        await _page.GotoAsync("https://jonathan-gartland.github.io/practice-pages");
    }

    public async Task inputValueAsync(string inVal)
    {
        await _mpnPosWellInput.FillAsync(inVal);
    }
    
    

}