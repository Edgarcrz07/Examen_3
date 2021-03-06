using Datos.Interfaces;
using Datos.Repositorios;
using ExamenTerceraUnidad.Data;
using ExamenTerceraUnidad.Interfaces;
using Modelos;

namespace ExamenTerceraUnidad.Servicios
{
    public class UsuarioServicio : IUsuarioServicio
    {
        private readonly MySQLConfiguration _configuration;
        private IUsuarioRepositorio usuarioRepositorio;

        public UsuarioServicio(MySQLConfiguration configuration)
        {
            _configuration = configuration;
            usuarioRepositorio = new UsuarioRepositorio(configuration.CadenaConexion);
        }


        public Task<bool> Actualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(Usuario usuario)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
