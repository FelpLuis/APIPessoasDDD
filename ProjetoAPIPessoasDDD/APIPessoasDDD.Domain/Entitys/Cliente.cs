using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPessoasDDD.Domain.Entitys
{ 
    public class Cliente : ID
    {
        public string Nome { get; set; }
        public int TipoCliente { get; set; }
        public int Endereco { get; set; }
        public int Contato { get; set; }
        public bool Ativo { get; set; } 

    }
}
