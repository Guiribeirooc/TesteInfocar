using FileImport.Interfaces;
using FileImport.Utils;
using System.Data;

namespace FileImport.Services
{
    public class FileService : IFileService
    {
        public DataSet ObterArquivoExcel(string file)
        {
            Stream reader = File.OpenRead(file);
            return FileExtensions.ObterArquivoExcel(reader);
        }
    }
}
