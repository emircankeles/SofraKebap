using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.LayoutComponents.UILayoutComponents
{
    public class _UILayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
