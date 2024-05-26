using AlmoxarifadoDomain.Models;
using AlmoxarifadoInfrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlmoxarifadoInfrastructure.Data.Repositories
{
    public class Itens_NotaRepository : IItens_NotaRepository
    {
        private readonly ContextSQL _context;

        public Itens_NotaRepository(ContextSQL context)
        {
            _context = context;
        }
        public List<ITENS_NOTA> ObterTodosOsItens()
        {
            return _context.Itens_Nota
                    .Select(g => new ITENS_NOTA
                    {
                        ITEM_NUM = g.ITEM_NUM,
                        ID_PRO = g.ID_PRO,
                        ID_NOTA = g.ID_NOTA,
                        ID_SEC = g.ID_SEC,
                        QTD_PRO = g.QTD_PRO,
                        PRE_UNIT = g.PRE_UNIT,
                        TOTAL_ITEM = g.TOTAL_ITEM,
                        EST_LIN = g.EST_LIN
                    })
                    .ToList();
        }
        public ITENS_NOTA ObterItensPorId(int id)
        {
            return _context.Itens_Nota
                    .Select(g => new ITENS_NOTA
                    {
                        ITEM_NUM = g.ITEM_NUM,
                        ID_PRO = g.ID_PRO,
                        ID_NOTA = g.ID_NOTA,
                        ID_SEC = g.ID_SEC,
                        QTD_PRO = g.QTD_PRO,
                        PRE_UNIT = g.PRE_UNIT,
                        TOTAL_ITEM = g.TOTAL_ITEM,
                        EST_LIN = g.EST_LIN
                    })
                    .ToList().First(x => x?.ID_PRO == id);
        }
        public ITENS_NOTA CriarItem(ITENS_NOTA itens)
        {
            _context.Itens_Nota.Add(itens);
            _context.SaveChanges();

            return itens;
        }
    }
}
