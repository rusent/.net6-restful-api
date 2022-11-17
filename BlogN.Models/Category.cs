using System.ComponentModel.DataAnnotations;

namespace BlogN.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
