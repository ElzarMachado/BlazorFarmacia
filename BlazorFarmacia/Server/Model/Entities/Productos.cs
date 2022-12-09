﻿using System.ComponentModel.DataAnnotations;
namespace BlazorFarmacia.Server.Model.Entities
{
    public class Productos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public int Cantidad { get; set; }

        public int Pasillo { get; set; }

        public string Fila { get; set; }

        public int PuntosCompra { get; set; }


        public int ProductosLotesId { get; set; }
        public ProductosLotes? ProductosLotes { get; set; }
    }
}