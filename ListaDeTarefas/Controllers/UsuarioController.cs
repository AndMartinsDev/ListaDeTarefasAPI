using ListaDeTarefas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListaDeTarefas.Controllers
{
    [Route("V1/api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UsuarioModel>> BuscaUsuarios()
        {
            return Ok(new List<UsuarioModel>());
        }
    }
}
