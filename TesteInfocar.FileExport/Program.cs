using FileExport.Interfaces;
using FileExport.Repositories;
using FileExport.Services;

IFileService fileService = new FileService();
IFileExportRepository fileExportRepository = new FileExportRepository(); 
IFileExportServices fileExportServices = new FileExportService(fileExportRepository, fileService);

Console.WriteLine("Iniciando processo de exportação do arquivo.");

var exportarArquivo = fileExportServices.ExportService();

File.WriteAllBytes(@"C:\\Users\\guilh\\TesteExportacaoInfoCar.csv", exportarArquivo.ToArray());

Console.WriteLine("Arquivo exportado com sucesso.");
Console.ReadKey();