using FileExport.Entities;
using FileExport.Interfaces;

namespace FileExport.Repositories
{
    public class FileExportRepository : IFileExportRepository
    {
        public List<Vehicle> GetData()
        {
            return new List<Vehicle>()
            {
                new Vehicle() 
                {
                    Id = "1",
                    Placa = "CCC-1S23",
                    Modelo = "Peugeot 208",
                    Versao = "Griffe 1.6",
                    AnoModelo = "2022",
                    AnoVersao = "2022",
                    Cambio = "Automático",
                    Cor = "Prata",
                    Portas = "4",
                    Quilometragem = "10.000",
                }
            };
        }
    }
}
