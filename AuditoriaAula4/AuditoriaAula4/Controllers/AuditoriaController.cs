using AuditoriaAula4.Model;
using AuditoriaAula4.Repositorio;
using System.Web.Http;

namespace AuditoriaAula4.Controllers
{
    [RoutePrefix("api/Auditoria")]
    public class AuditoriaController : ApiController
    {
        // POST api/values
        /// <summary>
        /// Audita uma venda de livros
        /// </summary>
        /// <param name="item">Dados para a auditoria.</param>
        [Route("Auditar")]
        [HttpPost]
        public RetornoAuditoria Post([FromBody]ItemAuditoria item)
        {
            AuditoriaRepositorio auditoria = new AuditoriaRepositorio();

            return auditoria.Auditar(item);
        }
    }
}
