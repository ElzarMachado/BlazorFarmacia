using System.ComponentModel.DataAnnotations;
namespace BlazorFarmacia.Server.Model.Entities
{
    public class ProductosLotes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int IdProducto  { get; set; }
        public int IdLote { get; set; }

        public List<Productos> Productos { get; set; }
        public List<Lotes> Lotes { get; set; } 

    }
}