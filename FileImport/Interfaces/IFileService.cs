using System.Data;

namespace FileImport.Interfaces
{
    public interface IFileService
    {
        DataSet ObterArquivoExcel(string file);
    }
}
