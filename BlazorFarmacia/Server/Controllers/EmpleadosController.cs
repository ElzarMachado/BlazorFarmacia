using BlazorFarmacia.Server.Model;
using BlazorFarmacia.Server.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorFarmacy.Server.Controllers
{
    [ApiController, Route("api/empleados")]
    public class EmpleadosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public EmpleadosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<EmpleadoDTO>>> GetEmpleados()
        {
            var empleados = await context.Empleados.ToListAsync();

            var empleadosDto = new List<EmpleadoDTO>();

            foreach (var empleado in empleados)
            {
                var empleadoDto = new EmpleadoDTO();
                empleadoDto.Id = empleado.Id;
                empleadoDto.Nombre = empleado.Nombre;
                

                empleadosDto.Add(empleadoDto);
            }
            return empleadosDto;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<EmpleadoDTO>> GetAlumno(int id)
        {
            var empleado = await context.Empleados
                .FirstOrDefaultAsync(x => x.Id == id);

            if (empleado == null)
            {
                return NotFound();
            }

            var empleadoDto = new EmpleadoDTO();
            empleadoDto.Id = empleado.Id;
            empleadoDto.Nombre = empleado.Nombre;
            

            return empleadoDto;
        }

        [HttpPost]
        public async Task<ActionResult> Add([FromBody] EmpleadoDTO empleadoDto)
        {
            var empleado = new Empleado();
            empleado.Nombre = empleadoDto.Nombre;
            

            context.Empleados.Add(empleado);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Edit([FromBody] EmpleadoDTO empleadoDto)
        {
            var empleadoDb = await context.Empleados
                .FirstOrDefaultAsync(x => x.Id == empleadoDto.Id);

            if (empleadoDb == null)
            {
                return NotFound();
            }

            empleadoDb.Nombre = empleadoDto.Nombre;
            

            context.Empleados.Update(empleadoDb);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var empleadoDb = await context.Empleados
                .FirstOrDefaultAsync(x => x.Id == id);

            if (empleadoDb == null)
            {
                return NotFound();
            }

            context.Empleados.Remove(empleadoDb);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}