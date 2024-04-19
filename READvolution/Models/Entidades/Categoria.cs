using System.ComponentModel.DataAnnotations;

namespace READvolution.Models.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]

        public string Nombre { get; set; }

        [DataType (DataType.MultilineText)]

        public String Descripcion { get; set; }
    }
}
