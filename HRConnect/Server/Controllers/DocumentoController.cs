using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect.Server.Controllers
{

    [ApiController]
    [Route("api/documento")]
    public class DocumentoController : ControllerBase
    {
        private IDocumentoRepository _documentoRepository;
        public DocumentoController(IDocumentoRepository documentoRepository)
        {
            _documentoRepository = documentoRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<Documento>> GetAllDocumenti()
        {
            return _documentoRepository.GetAllDocumenti().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteDocumento(int id)
        {
            _documentoRepository.DeleteDocumento(id);
        }

        [HttpPost("Add")]
        public ActionResult AddDocumento([FromBody] Documento nuovoDocumento)
        {
            if (nuovoDocumento == null)
            {
                return BadRequest("I dati del documento sono incompleti.");
            }
            _documentoRepository.AddDocumento(nuovoDocumento);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<Documento> UpdateDocumento(int id, Documento documento)
        {
            return _documentoRepository.UpdateDocumento(id, documento);
        }


    }
}
