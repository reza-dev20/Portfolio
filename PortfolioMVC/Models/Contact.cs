
using System.ComponentModel.DataAnnotations;

namespace PortfolioMVC.Models
{
	public class Contact
	{
		[Required(ErrorMessage ="فیلد اجباری است")]
		[MaxLength(100,ErrorMessage ="تنها 100 کاراکتر مجاز است")]
		[MinLength(3,ErrorMessage ="نام بسیار کوتاه است")]
		public string Name { get; set; }

		[Required(ErrorMessage = "فیلد اجباری است")]
		[EmailAddress]
		public string Email { get; set; }
		public string Message { get; set; }
		public string Service { get; set; }
	}
}
