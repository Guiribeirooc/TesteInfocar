using FileImport.Interfaces;
using FileImport.Models;
using System.Data.SqlClient;

namespace FileImport.Repositories
{
    public class FileImportRepository : IFileImportRepository
    {
        public void ImportData(List<SupplierDataDTO> supplierData)
        {
            SqlConnection connection = Connection();
            string sql = @"INSERT IGNORE INTO tb.import_data
                        (placa_antiga, cmt, nr_passageiros, busca)
                        VALUES
                        (@placa_antiga, @cmt, @nr_passageiros, @busca)";

            SqlCommand command = new SqlCommand(sql, connection);

            //connection.Open();

            foreach (var supplier in supplierData)
            {
                command.Parameters.AddWithValue("placa_antiga", supplier.PlacaAntiga);
                command.Parameters.AddWithValue("cmt", supplier.Cmt);
                command.Parameters.AddWithValue("nr_passageiros", supplier.NrPassageiros);
                command.Parameters.AddWithValue("busca", supplier.Busca);
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
