using SkymedTime.Models;
using System.Text.Json;

namespace SkymedTime.Providers
{
    public class AtletasProvider : Interfaces.IAtletasProvider
    {
        private Models.Atletas _atletas;

        public AtletasProvider()
        {
            this._atletas = JsonSerializer.Deserialize<Atletas>(Properties.Resources.TimeJson);
        }

        public IEnumerable<Atleta> GetAtletas()
        {
            return _atletas.AtletasCollection;
        }

        public IEnumerable<Models.CamisaAtleta> GetAtletas(int camisa)
        {
            return _atletas.AtletasCollection
                .Where(atleta => camisa == 0 || atleta.Camisa == camisa)
                .GroupBy(atleta => atleta.Camisa)
                .Select(item => new CamisaAtleta { Camisa = item.Key, Atletas = item }); 
        }

        public IEnumerable<Models.PosicaoAtleta> GetAtletas(string posicao)
        {
            return _atletas.AtletasCollection
                .Where(atleta => string.IsNullOrEmpty(posicao) || atleta.Posicao.ToLower().Equals(posicao.ToLower()) || atleta.Sigla.ToLower().Equals(posicao.ToLower()))
                .GroupBy(atleta => atleta.Posicao)
                .Select(item => new PosicaoAtleta { Posicao = item.Key, Atletas = item });
        }
    }
}
