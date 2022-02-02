namespace SkymedTime.Providers.Interfaces
{
    public interface IAtletasProvider
    {
        IEnumerable<Models.Atleta> GetAtletas();
        IEnumerable<Models.CamisaAtleta> GetAtletas(int camisa);
        IEnumerable<Models.PosicaoAtleta> GetAtletas(string posicao);
    }
}
