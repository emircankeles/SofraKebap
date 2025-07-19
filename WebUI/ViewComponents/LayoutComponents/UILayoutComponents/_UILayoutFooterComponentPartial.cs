using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.LayoutComponents.UILayoutComponents
{
    public class _UILayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
