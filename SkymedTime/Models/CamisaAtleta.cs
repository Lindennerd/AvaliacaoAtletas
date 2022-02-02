namespace SkymedTime.Models
{
    public class CamisaAtleta
    {
        public int Camisa { get; set; }
        public IEnumerable<Atleta> Atletas { get; set; }
    }
}
