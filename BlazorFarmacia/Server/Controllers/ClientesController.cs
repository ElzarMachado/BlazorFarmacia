using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorFarmacia.Server.Model;
using BlazorFarmacia.Shared.DTOS.Ventas;

namespace BlazorFarmacy.Server.Controllers
{
    [ApiController, Route("api/clientes")]
    public class ClientesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ClientesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClienteDTO>>> GetClientes()
        {
            var clientes = await context.Clientes.ToListAsync();

            var clientesDto = new List<ClienteDTO>();

            foreach (var cliente in clientes)
            {
                var clienteDto = new ClienteDTO();
                clienteDto.Id = cliente.Id;
                clienteDto.Nombre = cliente.Nombre;
                

                clientesDto.Add(clienteDto);
            }
            return clientesDto;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ClienteDTO>> GetCliente(int id)
        {
            var cliente = await context.Clientes
                .FirstOrDefaultAsync(x => x.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            var clienteDto = new ClienteDTO();
            clienteDto.Id = cliente.Id;
            clienteDto.Nombre = cliente.Nombre;
            

            return clienteDto;
        }

        [HttpPost]
        public async Task<ActionResult> Add([FromBody] ClienteDTO clienteDto)
        {
            var cliente = new Cliente();
            cliente.Nombre = clienteDto.Nombre;
            

            context.Clientes.Add(cliente);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Edit([FromBody] ClienteDTO clienteDto)
        {
            var clienteDb = await context.Clientes
                .FirstOrDefaultAsync(x => x.Id == clienteDto.Id);

            if (clienteDb == null)
            {
                return NotFound();
            }

            clienteDb.Nombre = clienteDb.Nombre;
            

            context.Clientes.Update(clienteDb);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var clienteDb = await context.Clientes
                .FirstOrDefaultAsync(x => x.Id == id);

            if (clienteDb == null)
            {
                return NotFound();
            }

            context.Clientes.Remove(clienteDb);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}