using System.ComponentModel.DataAnnotations;

namespace mvctraing.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string DisplayOrder { get; set; }

        public DateTime CreatedDate { get; set; }= DateTime.Now;
    }
}
