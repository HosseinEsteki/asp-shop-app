using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ShopApp.Models
{
    public class Image : BaseModel
    {
        public int Id { get; set; }


        [Display(Name = "نام فایل")]
        [MaxLength(255)]
        public string FileName { get; set; }
        [DataType(DataType.ImageUrl)]
        public string Url
        {
            get
            {
                string url = "/image/";
                if (UserId != null)
                {
                    url += "user/";
                }
                else if (ProductId != null)
                {
                    url += "product/";
                }
                else
                {
                    url += "category/";
                }
                url += FileName;
                return url;
            }
        }
        #region Relations
		[Display(Name ="محصول")]
        public int? ProductId { get; set; }
		[Display(Name ="محصول")]
        public Product? Product { get; set; }
		[Display(Name ="کاربر")]
        public int? UserId { get; set; }
		[Display(Name ="کاربر")]
        public User? User { get; set; }
		[Display(Name ="دسته")]
        public int? CategoryId { get; set; }
		[Display(Name ="دسته")]
        public Category? Category { get; set; }
        #endregion
    }
}
