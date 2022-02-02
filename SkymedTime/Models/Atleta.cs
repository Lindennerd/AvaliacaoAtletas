using System.Text.Json.Serialization;

namespace SkymedTime.Models
{
    public class Atleta
    {
        [JsonPropertyName("atleta_id")]
        public int Id { get; set; }
        [JsonPropertyName("nome_popular")]
        public string NomePopular { get; set; }
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("posicao")]
        public string Posicao { get; set; }
        [JsonPropertyName("sigla")]
        public string Sigla { get; set; }
        [JsonPropertyName("Camisa")]
        public int Camisa { get; set; }
    }
}
