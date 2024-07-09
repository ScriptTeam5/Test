using ConstructionPortal.DAL;

namespace ConstructionPortal.Models.DataModels
{
    public class ProductAttribute:BaseEntity
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
