using System.ComponentModel.DataAnnotations;
namespace BlazorFarmacia.Server.Model.Entities
{
    public class ProductoDTO
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int Cantidad { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int Pasillo { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Fila { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int PuntosCompra { get; set; }

    }
}