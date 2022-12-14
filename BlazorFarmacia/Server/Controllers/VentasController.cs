using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorFarmacia.Server.Model;
using BlazorFarmacia.Server.DTOs.Ventas;

namespace BlazorFarmacia.Server.Controllers
{
    [ApiController, Route("api/ventas")]

    public class VentasController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public VentasController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<VentaDTO>>> GetVentas()
        {
            var ventas = await context.Ventas.ToListAsync();

            var VentaDto = new List<VentaDTO>();

            foreach (var venta in ventas)
            {
                var VentaDto = new VentaDTO
                {
                    Id = venta.Id,
                    Fecha = venta.Fecha,
                    IdCliente = venta.IdCliente,
                    TotalVenta = venta.TotalVenta,
                    Folio = venta.Folio,
                    IdEmpleado = venta.IdEmpleado


                };


                VentasDTO.Add(VentaDto);
            }
            return VentaDto;
        }





        /////////////////////////////////////////////////////////////////////