using ExcelDataReader;
using System.Data;
using System.Text;

namespace FileImport.Utils
{
    public static class FileExtensions
    {
        public static DataSet ObterArquivoExcel(Stream fileStream)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            IExcelDataReader reader;
            reader = ExcelReaderFactory.CreateReader(fileStream);
            var configuration = new ExcelDataSetConfiguration
            {
                ConfigureDataTable = _ => new ExcelDataTableConfiguration
                {
                    UseHeaderRow = true
                }
            };

            return reader.AsDataSet(configuration);
        }
    }
}
