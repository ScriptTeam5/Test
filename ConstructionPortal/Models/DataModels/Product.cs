using ConstructionPortal.DAL;

namespace ConstructionPortal.Models.DataModels
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Image> Images { get; set; }
        public List<ProductAttribute> Attributes { get; set; }
        public List<Like> Likes { get; set; }
        public List<Favorite> Favorites { get; set; }
        public int LikeCount => Likes?.Count ?? 0;
        public int FavoriteCount => Favorites?.Count ?? 0;
    }
}
