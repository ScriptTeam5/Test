using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Text.Json.Serialization;
using ConstructionPortal.DAL;

namespace ConstructionPortal.Models.DataModels
{
    public class Image:BaseEntity
    {
        public string ImageUrl { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
