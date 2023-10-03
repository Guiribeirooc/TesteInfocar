using FileImport.Models;

namespace FileImport.Interfaces
{
    public interface IFileImportRepository
    {
        void ImportData(List<SupplierDataDTO> supplierData);
    }
}
