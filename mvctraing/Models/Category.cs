using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mvctraing.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName(" Display Order Name")]
        [Range(1,100,ErrorMessage ="Display Order must be between 1 to 100 ")]
        public string DisplayOrder { get; set; }

        public DateTime CreatedDate { get; set; }= DateTime.Now;
    }
}
