using System.ComponentModel.DataAnnotations;
namespace BlazorFarmacia.Server.Model.Entities
{
    public class Ventas
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Fecha { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int TotalVenta { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int Folio { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int IdEmpleado { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int IdProductosLotes { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int Importe { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int ValorUnitario { get; set; }


    }
}