namespace APIPessoasDDD.Application.Transfer
{
    public class TransferEndereco
    {
        public int Id {  get; set; }
        public string Longadouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public int TipoEndereco { get; set; }
        public bool Ativo {  get; set; }
    }
}
