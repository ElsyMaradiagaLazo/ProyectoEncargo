using Datos.Repositorio;
using Modelo;
using ProyectoEncargos.Data;
using ProyectoEncargos.Interfaces;

namespace ProyectoEncargos.Servicios
{
    public class EnvioServicio : IEnvioServicio
    {
        private readonly MySQLConfiguration _configuration;
        private EnvioRepositorio envioRepositorio;

        public EnvioServicio(MySQLConfiguration configuration)
        {
            _configuration = configuration;
            envioRepositorio = new EnvioRepositorio(configuration.CadenaConexion);
        }

        public async Task<bool> Actualizar(Envio envio)
        {
            return await envioRepositorio.Actualizar(envio);
        }

        public async Task<bool> Eliminar(Envio envio)
        {
            return await envioRepositorio.Eliminar(envio);
        }

        public async Task<IEnumerable<Envio>> GetLista()
        {
            return await envioRepositorio.GetLista();
        }

        public async Task<Envio> GetPorCodigo(string codigo)
        {
            return await envioRepositorio.GetPorCodigo(codigo);
        }

        public async Task<bool> Nuevo(Envio envio)
        {
            return await envioRepositorio.Nuevo(envio);
        }
    }
}
