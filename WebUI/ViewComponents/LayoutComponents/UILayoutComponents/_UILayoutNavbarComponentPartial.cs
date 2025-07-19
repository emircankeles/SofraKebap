using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.LayoutComponents.UILayoutComponents
{
    public class _UILayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
