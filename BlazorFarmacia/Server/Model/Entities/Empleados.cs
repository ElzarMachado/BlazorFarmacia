using System.ComponentModel.DataAnnotations;
namespace BlazorFarmacia.Server.Model.Entities
{
    public class Empleados
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        
        public int VentasId { get; set; }
        public Ventas? Ventas { get; set; }

    }
}