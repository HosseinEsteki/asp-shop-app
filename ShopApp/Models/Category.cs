using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace ShopApp.Models
{
    public class Category : BaseModel
    {
        public int Id { get; set; }
        [Display(Name = "نام دسته")]
        [MaxLength(50, ErrorMessage = "{0} نباید از 50 کاراکتر بیشتر باشد")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public string Name { get; set; }

        [Display(Name = "عنوان")]
        [MaxLength(255, ErrorMessage = "{0} نباید بیشتر از 255 کاراکتر باشد")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public string Title { get; set; }
        [Display(Name = "توضیح")]
        [MaxLength(255, ErrorMessage = "{0} نباید بیشتر از 255 کاراکتر باشد")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public string Description { get; set; }
        #region Relations
        [Display(Name = "تصویر")]
        public Image? Image { get; set; }
        [Display(Name = "سازنده")]
        public User? Creator { get; set; }
        [Display(Name = "سازنده")]
        public int? CreatorId { get; set; }
        [Display(Name = "برچسب‌ها")]

        public ICollection<Tag>? Tags { get; set; }
        [Display(Name = "محصولات")]
        public ICollection<Product>? Products { get; set; }
        [Display(Name = "مشخصات")]
        public ICollection<Property>? Properties { get; set; }
        #endregion

        
    }
}
