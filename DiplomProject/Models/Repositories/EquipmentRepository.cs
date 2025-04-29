using DiplomProject.Models.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomProject.Models.Repositories
{
    public class EquipmentRepository : BaseRepository
    {
        public EquipmentRepository(string connectionString)
        {
            this.connectionString = connectionString;   
        }

        public async Task<IEnumerable<Equipment>> GetAll()
        {
            var equipmentList = new List<Equipment>();
			using var connection = new SqlConnection(connectionString);
			using var command = new SqlCommand();

			await connection.OpenAsync();
			command.Connection = connection;
			command.CommandText = "SELECT * FROM Equipment";

			var reader = await command.ExecuteReaderAsync();
			while (reader.Read())
				equipmentList.Add(new Equipment { Id = reader.GetValue(0).ToString(), Errors = new List<Error>() });

			await reader.DisposeAsync();
			command.CommandText = "SELECT * FROM Errors";
			reader = await command.ExecuteReaderAsync();

			while (reader.Read())
			{
				var error = new Error();
				error.Severity = reader.GetValue(1).ToString();
				error.Code = reader.GetValue(2).ToString();
				error.Description = reader.GetValue(3).ToString();
				error.Date = DateTime.Parse(reader.GetValue(4).ToString());

				AddToEquipment(equipmentList, error, reader.GetValue(5).ToString());
			}

			await reader.DisposeAsync();
			return equipmentList;
        }

		private void AddToEquipment(List<Equipment> equipmentList, Error error, string? eqId)
		{
			var eq = equipmentList.FirstOrDefault(eq => eq.Id == eqId)!;
			eq.Errors.Add(error);
		}
    }
}