using EntregaModulo6.Data;
using EntregaModulo6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntregaModulo6.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PacoteController : ControllerBase
    {

        private readonly DataContext _dataContext;

        public PacoteController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pacote>>> GetPacote()
        {
            return await _dataContext.Pacote.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pacote>> GetPacoteById(int id)
        {
            var pacote = await _dataContext.Pacote.FindAsync(id);
            if (pacote == null)
            {
                return NotFound();
            }

            return Ok(pacote);
        }
    }
}
