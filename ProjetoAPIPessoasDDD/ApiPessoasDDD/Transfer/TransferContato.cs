namespace APIPessoasDDD.Application.Transfer
{
    public class TransferContato
    {
        public int Id { get; set; }
        public int TipoContato { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }
        public bool Ativo { get; set; }
    }
}
