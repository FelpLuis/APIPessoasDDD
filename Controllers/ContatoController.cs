using APIPessoasDDD.Application;
using APIPessoasDDD.Application.Interfaces;
using APIPessoasDDD.Application.Transfer;
using Microsoft.AspNetCore.Mvc;

namespace APIPessoasDDD.Services.Controllers
{
    [Route("APIPessoasDDD/contato")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        private readonly IApplicationServicoContato _applicationServicoContato;
        public ContatoController(IApplicationServicoContato ApplicationServicoContato)
        {
            _applicationServicoContato = ApplicationServicoContato;
        }

        [HttpGet("MostrarTodos")]
        public ActionResult<IEnumerable<string>> GetAll ()
        {
            return Ok (_applicationServicoContato.GetAll());
        }

        [HttpGet("BuscarId")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServicoContato.GetById(id));
        }


        [HttpPost("CadastrarContato")]
        public ActionResult Post([FromBody] TransferContato transferContato)
        {
            try
            {
                if (transferContato == null)
                    return NotFound();

                _applicationServicoContato.Add(transferContato);
                return Ok("Contato Cadastrado");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPut("EditarContato")]
        public ActionResult Put([FromBody] TransferContato transferContato)
        {
            try
            {
                if (transferContato == null)
                    return NotFound();

                _applicationServicoContato.Update(transferContato);
                return Ok("Contato Alterado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("ExcluirContato")]
        public ActionResult Delete([FromBody] TransferContato transferContato)
        {
            try
            {
                if (transferContato == null)
                    return NotFound();

                _applicationServicoContato.Remove(transferContato);
                return Ok("Contato Deleltado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
