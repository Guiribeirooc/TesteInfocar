using FileImport.Interfaces;
using FileImport.Repositories;
using FileImport.Services;

IFileService fileService = new FileService();
IFileImportRepository repository = new FileImportRepository();
IFileImportServices fileImportServices = new FileImportService(repository, fileService);

Console.WriteLine("Iniciando processo de importação do arquivo.");
var file = "C:\\Users\\Public\\teste-ti-processamento_fornecedor_fora_do_ar.xlsx";

try
{
    fileImportServices.ImportFile(file);
    Console.WriteLine("Arquivo importado com sucesso.");
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine($"Aconteceu algum erro ao exportar o arquivo. Exception {ex}");
}