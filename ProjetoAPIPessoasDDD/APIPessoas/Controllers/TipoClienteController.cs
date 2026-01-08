using APIPessoasDDD.Application.Interfaces;
using APIPessoasDDD.Application.Transfer;
using APIPessoasDDD.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIPessoasDDD.Services.Controllers
{
    [Route("APIPessoasDDD/Tipocliente")]
    [ApiController]
    public class TipoClienteController : ControllerBase
    {
        private readonly IApplicationServicoTipoCliente _applicationServicoTipoCliente;
        public TipoClienteController(IApplicationServicoTipoCliente applicationServicoTipoCliente)
        {
            _applicationServicoTipoCliente = applicationServicoTipoCliente;
        }

        [HttpGet("MostrarTodos")]
        public ActionResult<IEnumerable<string>> GetAll ()
        {
            return Ok (_applicationServicoTipoCliente.GetAll());
        }

        [HttpGet("BuscarId")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServicoTipoCliente.GetById(id));
        }


        [HttpPost("CadastrarTipoCliente")]
        public ActionResult Post([FromBody] TransferTipoCliente transferTipoCliente)
        {
            try
            {
                if (transferTipoCliente == null)
                    return NotFound();

                _applicationServicoTipoCliente.Add(transferTipoCliente);
                return Ok("Tipo Cliente Cadastrado");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPut("EditarTipoCliente")]
        public ActionResult Put([FromBody] TransferTipoCliente transferTipoCliente)
        {
            try
            {
                if (transferTipoCliente == null)
                    return NotFound();

                _applicationServicoTipoCliente.Update(transferTipoCliente);
                return Ok("Tipo Cliente Alterado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("ExcluirTipoCliente")]
        public ActionResult Delete([FromBody] TransferTipoCliente transferTipoCliente)
        {
            try
            {
                if (transferTipoCliente == null)
                    return NotFound();

                _applicationServicoTipoCliente.Remove(transferTipoCliente);
                return Ok("Tipo Cliente Deleltado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
