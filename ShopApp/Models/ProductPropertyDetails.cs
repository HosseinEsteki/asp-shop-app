namespace ShopApp.Models
{
    public class ProductPropertyDetails:BaseModel
    {
        public int Id { get; set; }
        public string Details { get; set; }
        #region Relations
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int? PropertyId { get; set; }
        public Property? Property { get; set; }

        #endregion
    }
}
