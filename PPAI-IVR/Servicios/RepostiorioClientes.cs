using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.JSInterop.Infrastructure;
using PPAI_IVR.Models.Clases;

namespace PPAI_IVR.Servicios
{
    public interface IRepositorioClientes
    {
        Task Actualizar(Cliente cliente);
        Task Borrar(int id);
        Task Crear(Cliente cliente);
        Task<bool> Existe(string nombre, int dni);
        Task<IEnumerable<Cliente>> Obtener();
        Task<Cliente> ObtenerPorId(int Id);
    }


    public class RepostiorioClientes : IRepositorioClientes
    {
        private readonly string connectionString;

        public RepostiorioClientes(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public async Task Crear(Cliente cliente)
        {
            using var connection = new SqlConnection(connectionString);

            try
            {
                var id = await connection.QuerySingleAsync<int>("INSERT INTO Clientes (NombreCompleto, nroCelular, Dni) VALUES (@NombreCompleto, @nroCelular, @Dni);" +
                                                               "SELECT SCOPE_IDENTITY();", cliente);

                // El ID del registro insertado está disponible en la variable 'id'

                // Haz algo con el ID, si es necesario
                cliente.Id = id;
                // ...
            }
            catch (Exception ex)
            {
                // Manejo de errores de conexión
                Console.WriteLine("Error de conexión a la base de datos: " + ex.Message);
            }
           

        }

        public async Task<bool> Existe(string nombrecompleto, int dni)
        {
            using var connection = new SqlConnection(connectionString);
            var existe = await connection.QueryFirstOrDefaultAsync<int>
                                                (@"SELECT 1
                                                 FROM Clientes
                                                 WHERE NombreCompleto = @NombreCompleto AND  Dni = @Dni",
                                                    new { nombrecompleto,dni });
            return existe == 1;
        }

        public async Task<IEnumerable<Cliente>> Obtener()
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryAsync<Cliente>
                                                (@"SELECT *
                                                    FROM Clientes                                                    
                                                    ORDER BY Id"
                                                    );

        }
        public async Task Actualizar(Cliente cliente)
        {
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync(@"UPDATE Clientes
                                            SET NombreCompleto = @NombreCompleto, Dni = @Dni , nroCelular =  @nroCelular
                                            WHERE Id = @Id", cliente);
        }
        public async Task<Cliente> ObtenerPorId(int Id)
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryFirstOrDefaultAsync<Cliente>
                                                (@"SELECT *
                                                    FROM Clientes
                                                    WHERE Id = @Id",
                                                    new { Id });

        }
        public async Task Borrar(int id)
        {
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync(@"DELETE Clientes                                           
                                            WHERE Id = @Id", new { id });
        }
        
    }
}
