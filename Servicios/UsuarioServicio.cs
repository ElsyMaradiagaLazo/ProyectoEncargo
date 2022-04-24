using Datos.Repositorio;
using Modelo;
using ProyectoEncargos.Data;
using ProyectoEncargos.Interfaces;

namespace ProyectoEncargos.Servicios
{
    public class UsuarioServicio : IUsuarioServicio
    {
        private readonly MySQLConfiguration _configuration;
        private UsuarioRepositorio usuarioRepositorio;

        public UsuarioServicio(MySQLConfiguration configuration)
        {
            _configuration = configuration;
            usuarioRepositorio = new UsuarioRepositorio(configuration.CadenaConexion);
        }

        public async Task<bool> Actualizar(Usuario usuario)
        {
            return await usuarioRepositorio.Actualizar(usuario);
        }

        public async Task<bool> Eliminar(Usuario usuario)
        {
            return await usuarioRepositorio.Eliminar(usuario);
        }

        public async Task<IEnumerable<Usuario>> GetLista()
        {
            return await usuarioRepositorio.GetLista();
        }

        public async Task<Usuario> GetPorCodigo(string codigo)
        {
            return await usuarioRepositorio.GetPorCodigo(codigo);
        }

        public async Task<bool> Nuevo(Usuario usuario)
        {
            return await usuarioRepositorio.Nuevo(usuario);
        }
    }
}

