using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ShopApp.Models
{
	public class Tag : BaseModel
    {
		public int Id { get; set; }
		[Display(Name= "عنوان")]
		[Required(ErrorMessage = "{0} الزامی است")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		public string Title { get; set; }

		[Display(Name= "نام")]
		[Required(ErrorMessage = "{0} الزامی است")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		public string Name { get; set; }


		#region Relations
		[Display(Name ="سازنده")]
		public User Creator { get; set; }
		[Display(Name ="سازنده")]
        public int CreatorId { get; set; }
		[Display(Name ="دسته‌ها")]
        public List<Category>? Categories { get; set; }
        #endregion
    }
}
