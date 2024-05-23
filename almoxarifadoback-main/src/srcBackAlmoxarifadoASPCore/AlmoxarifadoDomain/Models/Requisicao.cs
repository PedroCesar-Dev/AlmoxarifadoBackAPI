﻿namespace AlmoxarifadoDomain.Models
{
    public class REQUISICAO
    {
        public int ID_REQ { get; set; }
        public int ID_CLI { get; set; }
        public double TOTAL_REQ { get; set; }
        public int? QTD_ITEN { get; set; }
        public DateTime DATA_REQ { get; set; }
        public int ANO { get; set; }
        public int MES { get; set; }
        public int ID_SEC { get; set; }
        public int? ID_SET { get; set; }
        public string OBSERVACAO { get; set; }
    }
}
