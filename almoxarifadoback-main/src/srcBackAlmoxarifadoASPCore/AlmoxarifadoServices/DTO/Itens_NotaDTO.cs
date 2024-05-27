using System.Numerics;

namespace AlmoxarifadoServices.DTO
{
    public class Itens_NotaGetDTO
    {
        public int ITEM_NUM { get; set; }
        public int ID_PRO { get; set; }
        public int ID_NOTA { get; set; }
        public int ID_SEC { get; set; }
        public BigInteger? QTD_PRO { get; set; }
        public double? PRE_UNIT { get; set; }
        public double? TOTAL_ITEM { get; set; }
        public double? EST_LIN { get; set; }
    }
    public class Itens_NotaPostDTO
    {
        public int ITEM_NUM { get; set; }
        public int ID_PRO { get; set; }
        public int ID_NOTA { get; set; }
        public int ID_SEC { get; set; }
        public BigInteger? QTD_PRO { get; set; }
        public double? PRE_UNIT { get; set; }
        public double? TOTAL_ITEM { get; set; }
        public double? EST_LIN { get; set; }
    }
    public class Itens_NotaPutDTO
    {
        public int ITEM_NUM { get; set; }
        public int ID_PRO { get; set; }
        public int ID_NOTA { get; set; }
        public int ID_SEC { get; set; }
        public int QTD_PRO { get; set; }
        public decimal PRE_UNIT { get; set; }
        public decimal TOTAL_ITEM { get; set; }
        public string EST_LIN { get; set; }
    }
}
