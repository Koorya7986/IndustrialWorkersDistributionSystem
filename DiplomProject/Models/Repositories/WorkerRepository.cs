using DiplomProject.Models.Entities;
using Microsoft.Data.SqlClient;

namespace DiplomProject.Models.Repositories
{
    public class WorkerRepository : BaseRepository
    {
        public WorkerRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task<IEnumerable<Worker>> GetAll()
        {
            List<Worker> workers = new List<Worker>();

			using var connection = new SqlConnection(connectionString);
			using var command = new SqlCommand();

			await connection.OpenAsync();
			command.Connection = connection;
			command.CommandText = "SELECT * FROM Workers";

			using var reader = await command.ExecuteReaderAsync();
			while (reader.Read())
			{
				Worker worker = new Worker();
				worker.Id = reader.GetValue(0).ToString();
				worker.FullName = reader.GetValue(1).ToString();
				worker.Phone = reader.GetValue(2).ToString();
				worker.Experience = reader.GetValue(3).ToString();
				workers.Add(worker);
			}

			return workers;
        }
    }
}
