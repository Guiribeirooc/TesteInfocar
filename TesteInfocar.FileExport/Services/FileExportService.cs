using FileExport.Interfaces;
using FileExport.Models;

namespace FileExport.Services
{
    public class FileExportService : IFileExportServices
    {
        private readonly IFileExportRepository _repository;
        private readonly IFileService _fileService;

        public FileExportService(IFileExportRepository repository, IFileService fileService)
        {
            _repository = repository;
            _fileService = fileService;
        }

        public MemoryStream ExportService()
        {
            var vehicles = _repository.GetData();
            var vehicleDto = vehicles.Select(x => (VehicleDTO)x).ToList();
            var map = new VehicleMap();
            var stream = _fileService.GerarArquivoCSV(vehicleDto, map);

            return stream;
        }
    }
}
