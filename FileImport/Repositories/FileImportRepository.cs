using FileImport.Interfaces;
using FileImport.Models;
using System.Data.SqlClient;

namespace FileImport.Repositories
{
    public class FileImportRepository : IFileImportRepository
    {
        public void ImportData(List<SupplyDTO> supplyDto)
        {
            SqlConnection connection = Connection();
            string sql = @"INSERT IGNORE INTO tb.import_data
                        (placa_antiga, cmt, nr_passageiros, busca)
                        VALUES
                        (@placa_antiga, @cmt, @nr_passageiros, @busca)";

            SqlCommand command = new SqlCommand(sql, connection);

            //connection.Open();

            foreach (var supply in supplyDto)
            {
                command.Parameters.AddWithValue("placa_antiga", supply.PlacaAntiga);
                command.Parameters.AddWithValue("cmt", supply.Cmt);
                command.Parameters.AddWithValue("nr_passageiros", supply.NrPassageiros);
                command.Parameters.AddWithValue("busca", supply.Busca);
                //command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
        }
        private static SqlConnection Connection()
        {
            String connectionString = "";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
