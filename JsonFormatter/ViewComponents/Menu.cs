using Microsoft.AspNetCore.Mvc;

namespace JsonFormatter.ViewComponents;

public class Menu : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}