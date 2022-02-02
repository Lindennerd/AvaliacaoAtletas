using System.Text.Json.Serialization;

namespace SkymedTime.Models
{
    public class Atletas
    {
        [JsonPropertyName("ATLETA")]
        public IEnumerable<Atleta> AtletasCollection { get; set; }
    }
}
