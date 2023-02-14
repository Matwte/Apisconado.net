using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Modelos;
using WebApplication2.Repositorio;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("{nombreUsuario}/{contraseña}")]
        public Usuario GetUserNameByUserNameAndMail(string nombreUsuario, string contraseña)
        {
            var usuario = ManejadorUsuario.ObtenerUsuarioLogin(nombreUsuario, contraseña);
            return usuario == null ? new Usuario() : usuario;
        }

        [HttpGet("{nombreUsuario}")]
        public Usuario GetUserNameByUserName(string nombreUsuario)
        {
            var usuario = ManejadorUsuario.ObtenerNombreUsuario(nombreUsuario);
            return usuario == null ? new Usuario() : usuario;
        }


        [HttpPost]
        public void InsertUSer(Usuario usuario)
        {
            ManejadorUsuario.InsertarUsuario(usuario);
        }

        [HttpPut]
        public void UpdateUser(Usuario usuario)
        {
            ManejadorUsuario.ModificarUsuario(usuario);
        }
    }
}
