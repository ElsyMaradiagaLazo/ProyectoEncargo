using Modelo;

namespace ProyectoEncargos.Interfaces
{
    public interface IEnvioServicio
    {
        Task<bool> Nuevo(Envio envio);
        Task<bool> Actualizar(Envio envio);
        Task<bool> Eliminar(Envio envio);
        Task<IEnumerable<Envio>> GetLista();
        Task<Envio> GetPorCodigo(string codigoEnvio);
    }
}
