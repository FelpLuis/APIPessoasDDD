using APIPessoasDDD.Application.Interfaces;
using APIPessoasDDD.Application.Transfer;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APIPessoasDDD.Services.Controllers
{
    [Route("APIPessoasDDD/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IApplicationServicoCliente _applicationServicoCliente;
        public ClienteController(IApplicationServicoCliente applicationServicoCliente)
        {
            _applicationServicoCliente = applicationServicoCliente;
        }

        [HttpGet("MostrarTodos")]
        public async Task<ActionResult<IEnumerable<string>>> GetAll ()
        {
            var clientes =  _applicationServicoCliente.GetAll();
            return Ok (clientes);
        }

        [HttpGet("BuscarId")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServicoCliente.GetById(id));
        }


        [HttpPost("CadastrarCliente")]
        public ActionResult Post([FromBody] TransferCliente transferCadCliente)
        {
            try
            {
                if (transferCadCliente == null)
                    return NotFound();

                _applicationServicoCliente.Add(transferCadCliente);
                return Ok("Cliente Cadastrado");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPut("EditarCliente/{id}")]
        public ActionResult Put([FromBody] TransferCliente transferCliente)
        {
            try
            {
                if (transferCliente == null)
                    return NotFound();

                _applicationServicoCliente.Update(transferCliente);
                return Ok("Cliente Alterado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("ExcluirCliente")]
        public ActionResult Delete([FromBody] TransferCliente transferCliente)
        {
            try
            {
                if (transferCliente == null)
                    return NotFound();

                _applicationServicoCliente.Remove(transferCliente);
                return Ok("Cliente Deleltado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
