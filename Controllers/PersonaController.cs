using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SegundoCuatri1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {


        // POST api/<PersonaController>
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            List<Persona> personas = new List<Persona>();

            for (int i = 1; i <= 10; i++)
            {
                personas.Add(new Persona
                {
                    Id = i,
                    Nombre = $"Nombre{i}",
                    Apellido = $"Apellido{i}",
                    Edad = 20 + i,
                    Email = $"nombre{i}@mail.com"
                });
            }

            return Ok(personas);
        }



    }
}
