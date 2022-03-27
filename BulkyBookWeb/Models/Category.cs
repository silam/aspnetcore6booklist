using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        // dataannotation 
        // primary key, identity column
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;


    }
}
