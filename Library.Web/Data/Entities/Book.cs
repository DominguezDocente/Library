using System.ComponentModel.DataAnnotations;

namespace Library.Web.Data.Entities
{
    public class Book
    {
        public int Id { get; set; }

        [MaxLength(32, ErrorMessage = "El campo  {0} debe tener máximo {1} carácteres")]
        public string Title { get; set; }


        [MaxLength(128, ErrorMessage = "El campo  {0} debe tener máximo {1} carácteres")]
        public string Description { get; set; }

        public DateTime PublishDate { get; set; }

        public Author Author { get; set; }

        [MaxLength(32, ErrorMessage = "El campo  {0} debe tener máximo {1} carácteres")]
        public string Editorial { get; set; }

    }
}
