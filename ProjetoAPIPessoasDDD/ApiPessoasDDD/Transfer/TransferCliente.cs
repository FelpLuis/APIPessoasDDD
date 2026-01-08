namespace APIPessoasDDD.Application.Transfer
{
    public class TransferCliente 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int TipoCliente { get; set; }
        public int Endereco { get; set; }
        public int Contato { get; set; }
        public bool Ativo { get; set; }
    }
}
