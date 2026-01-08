using APIPessoasDDD.Application;
using APIPessoasDDD.Application.Interfaces;
using APIPessoasDDD.Application.Transfer;
using Microsoft.AspNetCore.Mvc;

namespace APIPessoasDDD.Services.Controllers
{
    [Route("APIPessoasDDD/Tipocontato")]
    [ApiController]
    public class TipoContatoController : ControllerBase
    {
        private readonly IApplicationServicoTipoContato _applicationServicoTipoContato;
        public TipoContatoController(IApplicationServicoTipoContato ApplicationServicoTipoContato)
        {
            _applicationServicoTipoContato = ApplicationServicoTipoContato;
        }

        [HttpGet("MostrarTodos")]
        public ActionResult<IEnumerable<string>> GetAll ()
        {
            return Ok (_applicationServicoTipoContato.GetAll());
        }

        [HttpGet("BuscarId")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServicoTipoContato.GetById(id));
        }


        [HttpPost("CadastrarTipoContato")]
        public ActionResult Post([FromBody] TransferTipoContato transferTipoContato)
        {
            try
            {
                if (transferTipoContato == null)
                    return NotFound();

                _applicationServicoTipoContato.Add(transferTipoContato);
                return Ok("Tipo Contato Cadastrado");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPut("EditarTipoContato")]
        public ActionResult Put([FromBody] TransferTipoContato transferTipoContato)
        {
            try
            {
                if (transferTipoContato == null)
                    return NotFound();

                _applicationServicoTipoContato.Update(transferTipoContato);
                return Ok("Tipo Contato Alterado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("ExcluirTipoContato")]
        public ActionResult Delete([FromBody] TransferTipoContato transferTipoContato)
        {
            try
            {
                if (transferTipoContato == null)
                    return NotFound();

                _applicationServicoTipoContato.Remove(transferTipoContato);
                return Ok("Tipo Contato Deleltado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
