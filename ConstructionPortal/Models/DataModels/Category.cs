using ConstructionPortal.DAL;

namespace ConstructionPortal.Models.DataModels
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public Category ParentCategory { get; set; }
        public List<Category> SubCategories { get; set; }
        public List<Product> Products { get; set; }
    }
}
