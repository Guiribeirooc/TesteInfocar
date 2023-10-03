using CsvHelper;
using CsvHelper.Configuration;
using FileExport.Interfaces;
using System.Globalization;

namespace FileExport.Services
{
    public class FileService : IFileService
    {
        public MemoryStream GerarArquivoCSV<T>(List<T> arquivo, ClassMap map)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ",",
                PrepareHeaderForMatch = args => args.Header.ToLower(),
                MissingFieldFound = null,
                HeaderValidated = null,
                LeaveOpen = true
            };

            var stream = new MemoryStream();
            using(var writeFile = new StreamWriter(stream, leaveOpen: true))
            {
                var csv = new CsvWriter(writeFile, config);
                csv.Context.RegisterClassMap(map);
                csv.WriteRecords(arquivo);
            }

            stream.Position = 0;
            return stream;
        }
    }
}
