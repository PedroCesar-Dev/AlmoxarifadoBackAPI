namespace AlmoxarifadoServices.DTO
{
    public class Nota_FiscalGetDTO
    {
        public int IdNota { get; set; }
        public int? IdFornecedor { get; set; }
        public int IdSec { get; set; }
        public string NumeroNota { get; set; }
        public double ValorNota { get; set; }
        public int QuantidadeItem { get; set; }
        public int? Icms { get; set; }
        public int? Iss { get; set; }
        public int Ano { get; set; }
        public int? Mes { get; set; }
        public DateTime? DataNota { get; set; }
        public int IdTipoNota { get; set; }
        public string ObservacaoNota { get; set; }
        public int? EmpenhoNumero { get; set; }

    }
    public class Nota_FiscalPostDTO
    {
        public int IdNota { get; set; }
        public int? IdFornecedor { get; set; }
        public int IdSec { get; set; }
        public string NumeroNota { get; set; }
        public double ValorNota { get; set; }
        public int QuantidadeItem { get; set; }
        public int? Icms { get; set; }
        public int? Iss { get; set; }
        public int Ano { get; set; }
        public int? Mes { get; set; }
        public DateTime? DataNota { get; set; }
        public int IdTipoNota { get; set; }
        public string ObservacaoNota { get; set; }
        public int? EmpenhoNumero { get; set; }

    }
}
