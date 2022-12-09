using System.ComponentModel.DataAnnotations;
namespace BlazorFarmacia.Server.Model.Entities
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        [Required]
        public int VentasId { get; set; }
        public Ventas? Ventas { get; set; }


    }
}
