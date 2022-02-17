using Microsoft.AspNetCore.Mvc;

namespace CoreLibrary.ViewComponents.Writer
{
	public class WriterNotification:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
