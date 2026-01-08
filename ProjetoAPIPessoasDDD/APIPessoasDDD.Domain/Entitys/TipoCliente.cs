using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPessoasDDD.Domain.Entitys
{
    public class TipoCliente : ID
    {
        public string Descricao { get; set; } 

        public bool Ativo { get; set; }
    }
}
