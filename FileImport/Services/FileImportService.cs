using FileImport.Interfaces;
using FileImport.Models;

namespace FileImport.Services
{
    public class FileImportService : IFileImportServices
    {
        private readonly IFileImportRepository _repository;
        private readonly IFileService _fileService;

        public FileImportService(IFileImportRepository repository, IFileService fileService)
        {
            _repository = repository;
            _fileService = fileService;
        }

        public bool ImportFile(string file)
        {
            var excel = _fileService.ObterArquivoExcel(file);
            var dados = excel.Tables[0].Rows;
            var suppliers = new List<SupplierDataDTO>();

            for (int linha = 0; linha < dados.Count; linha++)
            {
                var placa = dados[linha]["PLACA_ANTIGA"].ToString()?.Trim();
                var cmt = dados[linha]["CMT"].ToString()?.Trim();
                var nrPassageiros = dados[linha]["NR_PASSAGEIROS"].ToString()?.Trim();
                var busca = dados[linha]["BUSCA"].ToString()?.Trim();

                var supplierData = new SupplierDataDTO()
                {
                    PlacaAntiga = placa,
                    Cmt = cmt,
                    NrPassageiros = nrPassageiros,
                    Busca = busca
                };

                suppliers.Add(supplierData);
            }

            _repository.ImportData(suppliers);
            return true;
        }
    }
}
