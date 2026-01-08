using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPessoasDDD.Domain.Entitys
{
    public class Endereco : ID
    {
        public string Longadouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public int TipoEndereco { get; set; }
        public bool Ativo {  get; set; }

    }
}
