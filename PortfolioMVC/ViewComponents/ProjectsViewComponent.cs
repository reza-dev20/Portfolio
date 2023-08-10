using Microsoft.AspNetCore.Mvc;
using PortfolioMVC.Models;

namespace PortfolioMVC.ViewComponents
{
	public class ProjectsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke() {
			List<Project> projects = new List<Project>() 
			{
				new Project(1,"صرافی دیجیتال","خرید و فروش ارز دیجیتال...","Ali","project-1.jpg"),
				new Project(2,"Tracer","آنالیز داده های ورودی و خروجی...","Hasan","project-2.jpg"),
				new Project(1,"SEO","Search Engine Optimize...","Karim","project-3.jpg"),
				new Project(1,"تدرس خصوصی","آموزش زبان های برنامه نویسی","Sara","project-4.jpg")
			};
			return View("_Projects",projects);
		}
	}
}
