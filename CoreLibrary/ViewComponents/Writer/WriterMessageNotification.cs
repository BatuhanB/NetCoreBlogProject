using Microsoft.AspNetCore.Mvc;

namespace CoreLibrary.ViewComponents.Writer
{
	public class WriterMessageNotification:ViewComponent
	{
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
