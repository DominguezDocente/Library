using System.ComponentModel.DataAnnotations;

namespace Library.Web.DTOs
{
    public class AuthorDTO
    {
        public int Id { get; set; }

        [MaxLength(32, ErrorMessage = "El campo  {0} debe tener máximo {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string FirstName { get; set; }


        [MaxLength(32, ErrorMessage = "El campo  {0} debe tener máximo {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string LastName { get; set; }
    }
}
