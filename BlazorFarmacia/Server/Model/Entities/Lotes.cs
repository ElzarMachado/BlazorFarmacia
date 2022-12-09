using System.ComponentModel.DataAnnotations;
namespace BlazorFarmacia.Server.Model.Entities
{
    public class Lotes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Lote { get; set; }

        public string FechaCaducidad { get; set; }



        public int ProductosLotesId { get; set; }
        public ProductosLotes? ProductosLotes { get; set; }
    }
}