using Microsoft.AspNetCore.Mvc;
using PortfolioMVC.Models;

namespace PortfolioMVC.ViewComponents
{
	public class LatestArticleViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke() 
		{
			var Articles = new List<Article>() 
			{
				new Article(1,"Angular","دوره حرفه ای صفر تا صد Angular","blog-post-thumb-card-1.jpg"),
				new Article(2,"برنامه نویسی چیست ؟‌ ","همه چیز هایی که باید بدانید + کاربردها","blog-post-thumb-card-2.jpg"),
				new Article(3,"صفحه نمایش لپ تاپ","معرفی انواع صفحه نمایش لپ تاپ","blog-post-thumb-card-3.jpg"),
				new Article(4,"جاوااسکریپت","دوره آموزش جاوااسکریپت","blog-post-thumb-card-4.jpg")
			};
			return View("_LatestArticle",Articles);
		}
	}
}
