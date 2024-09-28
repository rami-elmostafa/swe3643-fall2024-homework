using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]

public class GeneratedTest : PageTest
{
    [Test]
    public async Task MyTest()
    {
        await Page.GotoAsync("https://demo.playwright.dev/todomvc/");
        await Page.GotoAsync("https://demo.playwright.dev/todomvc/#/");
        await Page.GetByPlaceholder("What needs to be done?").ClickAsync();
        await Page.GetByPlaceholder("What needs to be done?").PressAsync("CapsLock");
        await Page.GetByPlaceholder("What needs to be done?").FillAsync("C");
        await Page.GetByPlaceholder("What needs to be done?").PressAsync("CapsLock");
        await Page.GetByPlaceholder("What needs to be done?").FillAsync("Complete ");
        await Page.GetByPlaceholder("What needs to be done?").ClickAsync();
        await Page.GetByPlaceholder("What needs to be done?").FillAsync("Complete homework 3");
        await Page.GetByPlaceholder("What needs to be done?").PressAsync("Enter");
        await Page.GetByLabel("Toggle Todo").CheckAsync();
        await Page.GetByRole(AriaRole.Button, new() { Name = "Clear completed" }).ClickAsync();
        //await Expect(Page).ToHaveTextAsync("0 items left");
    }
}

