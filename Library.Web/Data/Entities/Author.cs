using System.ComponentModel.DataAnnotations;

namespace Library.Web.Data.Entities
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(32, ErrorMessage = "El campo  {0} debe tener máximo {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Nombres")]
        public string FirstName { get; set; }

        [MaxLength(32, ErrorMessage = "El campo  {0} debe tener máximo {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

    }
}
