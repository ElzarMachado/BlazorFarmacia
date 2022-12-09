using System.ComponentModel.DataAnnotations;
namespace BlazorFarmacia.Server.Model.Entities
{
    public class Ventas
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Fecha { get; set; }
        [Required]

        public int IdCliente { get; set; }
        [Required]
        public int TotalVenta { get; set; }
        [Required]
        public int Folio { get; set; }
        [Required]
        public int IdEmpleado { get; set; }
        [Required]
        public int IdProductosLotes { get; set; }
        [Required]
        public int Importe { get; set; }
        [Required]
        public int ValorUnitario { get; set; }


        public List<Clientes> Clientes { get; set; }
        public List<Empleados> Empleados { get; set; } 
        public List<ProductosLotes> ProductosLotes { get; set; }



    }
}