using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ShopApp.Models
{
	public class Product : BaseModel
    {
		public int Id { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
        public string Name { get; set; }
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
        public string Title { get; set; }
        [Display(Name= "توضیحات محصول")]
		[Required(ErrorMessage = "{0} الزامی است")]
		public string Description { get; set; }
		[Display(Name= "قیمت")]
		[Required(ErrorMessage = "{0} الزامی است")]

		public ulong Price { get; set; }
		[Display(Name= "موجودی")]
		[Required(ErrorMessage = "{0} الزامی است")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		public int Total { get; set; }
		[Display(Name= "وضعیت انتشار")]
		[Required(ErrorMessage = "{0} الزامی است")]
		public bool Published { get; set; }
		[Display(Name ="مشخصات")]
		public ICollection<ProductPropertyDetails>? Properties { get; set; }
		[Display(Name ="تصاویر")]
        public ICollection<Image> Images { get; set; }
		[Display(Name ="دسته")]
        public Category Category { get; set; }
		[Display(Name ="دسته")]
        public int CategoryId { get; set; }
		[Display(Name ="سازنده")]
        public User Creator { get; set; }
		[Display(Name ="سازنده")]
        public int CreatorId { get; set; }
        
	}
}
