using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopApp.Models.Auth
{
    public class Role
    {
        public int Id { get; set; }
        [Display(Name = "نام دسترسی")]
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Permission> Permissions { get; set; }
        #region TimeStamp
        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Display(Name = "تاریخ ویرایش")]
        public DateTime UpdatedAt { get; set; }
        #endregion

    }
}
