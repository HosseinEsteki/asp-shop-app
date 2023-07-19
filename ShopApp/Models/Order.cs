using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ShopApp.Models
{
    public class Order : BaseModel
    {

        public int Id { get; set; }
        [Display(Name = "وضعیت سفارش")]
        public string Status { get; set; }
        [Display(Name = "آدرس")]
        public string Address { get; set; }
		[Display(Name ="سفارش دهنده")]
        public int CustomerId { get; set; }
        [Display(Name = "سفارش دهنده")]
        public User? Customer { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
        


    }
}
