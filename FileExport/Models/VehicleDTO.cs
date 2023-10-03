using FileExport.Entities;

namespace FileExport.Models
{
    public class VehicleDTO
    {
        public static implicit operator VehicleDTO(Vehicle entity)
        {
            VehicleDTO vehicleDTO = new VehicleDTO
            {
                Id = entity.Id.Substring(0, entity.Id.Length >= 30 ? 30 : entity.Id.Length),
                Placa = entity.Placa.Substring(0, entity.Placa.Length >= 30 ? 30 : entity.Placa.Length),
                Modelo = entity.Modelo.Substring(0, entity.Modelo.Length >= 30 ? 30 : entity.Modelo.Length),
                Versao = entity.Versao.Substring(0, entity.Versao.Length >= 30 ? 30 : entity.Versao.Length),
                Portas = entity.Portas.Substring(0, entity.Portas.Length >= 30 ? 30 : entity.Portas.Length),
                AnoModelo = entity.AnoModelo.Substring(0, entity.AnoModelo.Length >= 30 ? 30 : entity.AnoModelo.Length),
                AnoVersao = entity.AnoVersao.Substring(0, entity.AnoVersao.Length >= 30 ? 30 : entity.AnoVersao.Length),
                Cor = entity.Cor.Substring(0, entity.Cor.Length >= 30 ? 30 : entity.Cor.Length),
                Cambio = entity.Cambio.Substring(0, entity.Cambio.Length >= 30 ? 30 : entity.Cambio.Length),
                Quilometragem = entity.Quilometragem.Substring(0, entity.Quilometragem.Length >= 30 ? 30 : entity.Quilometragem.Length)
            };
            return entity == null ? null : vehicleDTO;
        }

        public string Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Versao { get; set; }
        public string Portas { get; set; }
        public string AnoModelo { get; set; }
        public string AnoVersao { get; set; }
        public string Cor { get; set; }
        public string Cambio { get; set; }
        public string Quilometragem { get; set; }
    }
}
