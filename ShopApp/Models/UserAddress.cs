using System.ComponentModel.DataAnnotations;

namespace ShopApp.Models
{
    public class UserAddress : BaseModel
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "{0} الزامی است.")]
        [MaxLength(50, ErrorMessage = "{0} نباید از {1} کاراکتر بیشتر باشد.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "{0} الزامی است.")]
        [MaxLength(50, ErrorMessage = "{0} نباید از {1} کاراکتر بیشتر باشد.")]

        public string Shire { get; set; }
        [Required(ErrorMessage = "{0} الزامی است.")]
        [MaxLength(50, ErrorMessage = "{0} نباید از {1} کاراکتر بیشتر باشد.")]
        public string City { get; set; }
        [Required(ErrorMessage = "{0} الزامی است.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "{0} الزامی است.")]
        public int Plaque { get; set; }
        [Required(ErrorMessage = "{0} الزامی است.")]
        [StringLength(10,MinimumLength =10,ErrorMessage ="{0} باید 10 کاراکتر باشد.")]
        public string PostalCode { get; set; }

        #region Relations
        public int? UserId { get; set; }
        public User? User { get; set; }
        #endregion

    }
}
