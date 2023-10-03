using FileExport.Interfaces;
using FileExport.Repositories;
using FileExport.Services;

IFileService fileService = new FileService();
IFileExportRepository fileExportRepository = new FileExportRepository();
IFileExportServices fileExportServices = new FileExportService(fileExportRepository, fileService);

Console.WriteLine("Iniciando processo de exportação do arquivo.");

try
{
    var exportarArquivo = fileExportServices.ExportService();
    var nomeArquivo = $"TesteExportacaoInfocar_{DateTime.Now.ToString("yyyyMMdd")}.csv";
    File.WriteAllBytes($"C:\\Users\\Public\\{nomeArquivo}", exportarArquivo.ToArray());

    Console.WriteLine("Arquivo exportado com sucesso.");
    Console.ReadKey();
}
catch(Exception ex)
{
    Console.WriteLine($"Aconteceu algum erro ao exportar o arquivo. Exception {ex}");
}