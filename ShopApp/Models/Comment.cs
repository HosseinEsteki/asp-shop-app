using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ShopApp.Models
{
    public class Comment : BaseModel
    {
        public int Id { get; set; }
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [MaxLength(20, ErrorMessage = "{0} نباید بیشتر از 20 کاراکتر باشد")]
        public string Title { get; set; }
        [Display(Name = "متن")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [MaxLength(300, ErrorMessage = "{0} نباید بیشتر از 300 کاراکتر باشد")]
        public string Content { get; set; }
        [Display(Name = "وضعیت انتشار")]
        public byte Status { get; set; }

        #region Relations
		[Display(Name ="محصول")]
        public int ProductId { get; set; }
		[Display(Name ="محصول")]
        public Product Product { get; set; }
		[Display(Name ="سازنده")]
        public User? Creator { get; set; }
		[Display(Name ="سازنده")]
        public int? CreatorId { get; set; }
        #endregion
    }
}
