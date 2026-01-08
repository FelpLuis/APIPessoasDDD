using APIPessoasDDD.Application;
using APIPessoasDDD.Application.Interfaces;
using APIPessoasDDD.Application.Transfer;
using Microsoft.AspNetCore.Mvc;

namespace APIPessoasDDD.Services.Controllers
{
    [Route("APIPessoasDDD/TipoEndereco")]
    [ApiController]
    public class TipoEnderecoController : ControllerBase
    {
        private readonly IApplicationServicoTipoEndereco _applicationServicoTipoEndereco;
        public TipoEnderecoController(IApplicationServicoTipoEndereco ApplicationServicoTipoEndereco)
        {
            _applicationServicoTipoEndereco = ApplicationServicoTipoEndereco;
        }

        [HttpGet("MostrarTodos")]
        public ActionResult<IEnumerable<string>> GetAll ()
        {
            return Ok (_applicationServicoTipoEndereco.GetAll());
        }

        [HttpGet("BuscarId")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServicoTipoEndereco.GetById(id));
        }


        [HttpPost("CadastrarTipoEndereco")]
        public ActionResult Post([FromBody] TransferTipoEndereco transferTipoEndereco)
        {
            try
            {
                if (transferTipoEndereco == null)
                    return NotFound();

                _applicationServicoTipoEndereco.Add(transferTipoEndereco);
                return Ok("Tipo Endereco Cadastrado");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPut("EditarTipoEndereco")]
        public ActionResult Put([FromBody] TransferTipoEndereco transferTipoEndereco)
        {
            try
            {
                if (transferTipoEndereco == null)
                    return NotFound();

                _applicationServicoTipoEndereco.Update(transferTipoEndereco);
                return Ok("Tipo Endereco Alterado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("ExcluirTipoEndereco")]
        public ActionResult Delete([FromBody] TransferTipoEndereco transferTipoEndereco)
        {
            try
            {
                if (transferTipoEndereco == null)
                    return NotFound();

                _applicationServicoTipoEndereco.Remove(transferTipoEndereco);
                return Ok("Tipo Endereco Deleltado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
