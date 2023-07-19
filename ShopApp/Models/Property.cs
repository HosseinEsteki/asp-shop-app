using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ShopApp.Models
{
	public class Property : BaseModel
    {
		public int Id { get; set; }
		[Required(ErrorMessage = "{0} الزامی است")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name="نام ویژگی")]
		public string Name { get; set; }
		#region Relation
		[Display(Name ="دسته‌ها")]
		public ICollection<Category> Categories { get; set; }
		public ICollection<ProductPropertyDetails>? Products { get; set; }
        [Display(Name ="سازنده")]
        public User Creator { get; set; }
		[Display(Name ="سازنده")]
        public int CreatorId { get; set; }
        #endregion


    }
}
