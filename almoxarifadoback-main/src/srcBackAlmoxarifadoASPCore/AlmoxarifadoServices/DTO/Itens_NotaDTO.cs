using System.Numerics;

namespace AlmoxarifadoServices.DTO
{
    public class Itens_NotaDTO
    {
        public class Itens_NotaGetDTO
        {
            public int ItemNum { get; set; }
            public int IdProduto { get; set; }
            public int IdNota { get; set; }
            public int IdSec { get; set; }
            public BigInteger? QuantidadeProduto { get; set; }
            public double? PrecoUnitario { get; set; }
            public double? TotalItem { get; set; }
            public double? EstoqueLinha { get; set; }
        }
        public class Itens_NotaPostDTO
        {
            public int ItemNum { get; set; }
            public int IdProduto { get; set; }
            public int IdNota { get; set; }
            public int IdSec { get; set; }
            public BigInteger? QuantidadeProduto { get; set; }
            public double? PrecoUnitario { get; set; }
            public double? TotalItem { get; set; }
            public double? EstoqueLinha { get; set; }
        }
    }
}
