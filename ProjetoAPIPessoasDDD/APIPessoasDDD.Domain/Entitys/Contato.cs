using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPessoasDDD.Domain.Entitys
{
    public class Contato : ID
    {
        public int TipoContato { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }
        public bool Ativo { get; set; }
    }
}
