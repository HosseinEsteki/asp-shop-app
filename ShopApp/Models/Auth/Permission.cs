using System.ComponentModel.DataAnnotations;

namespace ShopApp.Models.Auth
{
    public class Permission
    {
        public int Id { get; set; }
        [Display(Name = "نام قابلیت")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]

        public string Name { get; set; }
        public ICollection<Role> Roles { get; set; }
        #region TimeStamp
        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Display(Name = "تاریخ ویرایش")]
        public DateTime UpdatedAt { get; set; }
        #endregion

    }
}
