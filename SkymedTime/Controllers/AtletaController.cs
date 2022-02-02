using Microsoft.AspNetCore.Mvc;
using SkymedTime.Providers.Interfaces;

namespace SkymedTime.Controllers
{
    [Route("api/atletas")]
    [ApiController]
    public class AtletaController : ControllerBase
    {
        private readonly IAtletasProvider atletasProvider;
        private readonly ILogger logger;

        public AtletaController(IAtletasProvider atletasProvider, ILogger<AtletaController> logger)
        {
            this.atletasProvider = atletasProvider;
            this.logger = logger;
        }

        /// <summary>
        ///  Listagem de todos os jogadores do time de futebol com suas respectivas características.
        /// </summary>
        /// <returns>Lista de Jogadores</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Models.Atletas>), StatusCodes.Status200OK)]
         public ActionResult GetAtletas()
        {
            try
            {
                var atletas = atletasProvider.GetAtletas();
                return Ok(atletas);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message, ex);
                throw;
            }
        }

        /// <summary>
        /// Listar jogadores por número de camiseta (a api deve permitir que o usuário filtre o número da camiseta desejada)
        /// </summary>
        /// <param name="camisa">Parametro opcional camisa</param>
        /// <returns>Lista de jogadores agrupados pelo número de suas respectivas camisas</returns>
        [HttpGet("camisa")]
        [ProducesResponseType(typeof(IEnumerable<Models.CamisaAtleta>), StatusCodes.Status200OK)]
        public ActionResult GetAtletas(int camisa)
        {
            try
            {
                var atletas = atletasProvider.GetAtletas(camisa).ToList();
                return Ok(atletas);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message, ex);
                throw;
            }
        }

        /// <summary>
        /// Listar jogadores por posição de campo(a api deve permitir que o usuário filtre a posição do jogador)
        /// </summary>
        /// <param name="posicao"></param>
        /// <returns></returns>
        [HttpGet("posicao")]
        [ProducesResponseType(typeof(IEnumerable<Models.PosicaoAtleta>), StatusCodes.Status200OK)]

        public ActionResult GetAtletas(string? posicao)
        {
            try
            {
                var atletas = atletasProvider.GetAtletas(posicao);
                return Ok(atletas);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message, ex);
                throw;
            }
        }
    }
}
