using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using to_do.Classes;

namespace to_do.Controllers
{
    [ApiController]
    [Route("usuario")]
    public class UsuarioController : ControllerBase
    {
        private Context context;
        public UsuarioController(Context context)
        {
            this.context = context;
        }

        [HttpGet(Name = "getUsuarios")]
        public async Task<List<Usuario>> Get()
        {
            return await context.Usuarios.ToListAsync();
        }

    }
}
