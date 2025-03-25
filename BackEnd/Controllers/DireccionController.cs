using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Admin")]
    public class DireccionController : ControllerBase
    {
        IDireccionService _direccionService;
        ILogger<DireccionController> _logger;

        public DireccionController(IDireccionService direccionService, ILogger<DireccionController> logger)
        {
            _direccionService = direccionService;
            _logger = logger;
        }

        // GET: api/<DireccionController>
        [HttpGet]
        [Authorize(Roles ="Admin")]
        public IEnumerable<DireccionDTO> Get()
        {
            _logger.LogDebug("Obtener direcciones registradas");
            return _direccionService.GetDirecciones();
        }

        // GET api/<DireccionController>/5
        [HttpGet("{id}")]
        public DireccionDTO Get(int id)
        {
            return _direccionService.GetDireccionByID(id);
        }

        // POST api/<DireccionController>
        [HttpPost]
        public void Post([FromBody] DireccionDTO direccion)
        {
            _direccionService.AddDireccion(direccion);
        }

        // PUT api/<DireccionController>/5
        [HttpPut]
        public void Put([FromBody] DireccionDTO direccion)
        {
            try
            {
                _direccionService.UpdateDireccion(direccion);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }

        // DELETE api/<DireccionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _direccionService.DeleteDireccion(id);
        }
    }

}
