using APIPessoasDDD.Application;
using APIPessoasDDD.Application.Interfaces;
using APIPessoasDDD.Application.Transfer;
using Microsoft.AspNetCore.Mvc;

namespace APIPessoasDDD.Services.Controllers
{
    [Route("APIPessoasDDD/Endereco")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IApplicationServicoEndereco _applicationServicoEndereco;
        public EnderecoController(IApplicationServicoEndereco ApplicationServicoEndereco)
        {
            _applicationServicoEndereco = ApplicationServicoEndereco;
        }

        [HttpGet("MostrarTodos")]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            return Ok (_applicationServicoEndereco.GetAll());
        }

        [HttpGet("BuscarId")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServicoEndereco.GetById(id));
        }


        [HttpPost("CadastrarEndereco")]
        public ActionResult Post([FromBody] TransferEndereco transferEndereco)
        {
            try
            {
                if (transferEndereco == null)
                    return NotFound();

                _applicationServicoEndereco.Add(transferEndereco);
                return Ok("Endereco Cadastrado");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPut("EditarEndereco")]
        public ActionResult Put([FromBody] TransferEndereco transferEndereco)
        {
            try
            {
                if (transferEndereco == null)
                    return NotFound();

                _applicationServicoEndereco.Update(transferEndereco);
                return Ok("Endereco Alterado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("ExcluirEndereco")]
        public ActionResult Delete([FromBody] TransferEndereco transferEndereco)
        {
            try
            {
                if (transferEndereco == null)
                    return NotFound();

                _applicationServicoEndereco.Remove(transferEndereco);
                return Ok("Endereco Deleltado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
