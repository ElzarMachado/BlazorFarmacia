using System.ComponentModel.DataAnnotations;
namespace BlazorFarmacia.Server.Model.Entities
{
    public class ProductoLoteDTO
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int IdProducto { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int IdLote { get; set; }


    }
}