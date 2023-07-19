using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using ShopApp.Models.Auth;

namespace ShopApp.Models
{
    public class User : BaseModel
    {
        public int Id { get; set; }

        [Display(Name = "آدرس ایمیل")]
        [EmailAddress(ErrorMessage = "{0} باید از فرمت ایمیل باشد")]
        [MaxLength(255, ErrorMessage = "{0} نباید بیشتر از 255 کاراکتر باشد")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public string Email { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [DataType(DataType.Password)]
        [MaxLength(20, ErrorMessage = "{0} نباید بیشتر از 20 کاراکتر باشد")]
        [MinLength(8, ErrorMessage = "{0} نباید کمتر از 8 کاراکتر باشد")]
        public string Password { get; set; }

        [Display(Name = "نام")]
        [MaxLength(20, ErrorMessage = "{0} نباید بیشتر از 20 کاراکتر باشد")]
        public string? FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [MaxLength(20, ErrorMessage = "{0} نباید بیشتر از 20 کاراکتر باشد")]

        public string? LastName { get; set; }
        public string Name
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        
        [Display(Name = "کد ملی")]
        [StringLength(10, ErrorMessage = "{0} باید 10 کاراکتر باشد")]
        public string? MelliCode { get; set; }
        #region Relations
        //public Role Role { get; set; }
        //public int RoleId { get; set; }
        [Display(Name = "آدرس")]
        public List<UserAddress>? Address { get; set; }
        [Display(Name = "نظرات")]
        public ICollection<Comment>? Comments { get; set; }
        [Display(Name = "برچسب‌ها")]
        public ICollection<Tag>? Tags { get; set; }
        [Display(Name = "سفارشات")]
        public ICollection<Order>? Orders { get; set; }
        [Display(Name = "دسته‌بندی‌‌ها")]
        public ICollection<Category>? Categories { get; set; }
        [Display(Name = "محصولات")]
        public ICollection<Product>? Products { get; set; }
        [Display(Name = "مشخصات")]
        public ICollection<Property>? Properties { get; set; }

        [Display(Name = "تصویر پروفایل")]
        public Image Image { get; set; }
        #endregion
    }
}
