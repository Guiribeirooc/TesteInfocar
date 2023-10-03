using CsvHelper.Configuration;

namespace FileExport.Interfaces
{
    public interface IFileService
    {
        MemoryStream GerarArquivoCSV<T>(List<T> arquivo, ClassMap map);
    }
}
