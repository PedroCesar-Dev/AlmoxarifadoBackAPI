﻿using System.Numerics;

namespace AlmoxarifadoDomain.Models
{
    public class ITENS_REQ
    {
        public int NUM_ITEM { get; set; }
        public int ID_PRO { get; set; }
        public int ID_REQ { get; set; }
        public int ID_SEC { get; set; }
        public BigInteger QTD_PRO { get; set; }
        public double? PRE_UNIT { get; set; }
        public double? TOTAL_ITEM { get; set; }
        public double? TOTAL_REAL { get; set; }
    }
}
