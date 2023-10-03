using CsvHelper.Configuration;

namespace FileExport.Models
{
    public class VehicleMap : ClassMap<VehicleDTO>
    {
        public VehicleMap()
        {
            Map(x => x.Id).Name("ID_VEICULO");
            Map(x => x.Placa).Name("PLACA_VEICULO");
            Map(x => x.Modelo).Name("MODELO_VEICULO");
            Map(x => x.Versao).Name("VERSAO_VEICULO");
            Map(x => x.AnoModelo).Name("ANO_MODELO_VEICULO");
            Map(x => x.AnoVersao).Name("ANO_VERSAO_VEICULO");
            Map(x => x.Portas).Name("PORTAS_VEICULO");
            Map(x => x.Cor).Name("COR_VEICULO");
            Map(x => x.Cambio).Name("CAMBIO_VEICULO");
            Map(x => x.Quilometragem).Name("KM_VEICULO");
        }
    }
}
