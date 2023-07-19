using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ShopApp.Models
{
    public class OrderDetail : BaseModel
    {
        public int Id { get; set; }
        public ulong? Price { get; set; }
        #region Relations
		[Display(Name ="محصول")]
        public int? ProductId { get; set; }
		[Display(Name ="محصول")]
        public Product? Product { get; set; }
		[Display(Name ="شماره سفارش")]
        public int OrderId { get; set; }
		[Display(Name ="شماره سفارش")]
        public Order Order { get; set; }
        #endregion
        


    }
}
