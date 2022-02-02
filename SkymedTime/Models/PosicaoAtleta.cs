namespace SkymedTime.Models
{
    public class PosicaoAtleta
    {
        public string Posicao { get; internal set; }
        public IGrouping<string, Atleta> Atletas { get; internal set; }
    }
}
