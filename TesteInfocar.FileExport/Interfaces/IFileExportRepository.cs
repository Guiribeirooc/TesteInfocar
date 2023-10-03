using FileExport.Entities;

namespace FileExport.Interfaces
{
    public interface IFileExportRepository
    {
        List<Vehicle> GetData();
    }
}
