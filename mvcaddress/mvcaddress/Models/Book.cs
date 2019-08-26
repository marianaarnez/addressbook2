namespace mvcaddress.Models
{
    using System.ComponentModel.DataAnnotations;
    public enum TypeContact
    {
        telephone,
        email,
        facebook,
        twitter,
    }

    public class Book
    {
        [Key]
        public int bookID { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public TypeContact type { get; set; }
        [Required]
        public string Contact { get; set; }

    }
}