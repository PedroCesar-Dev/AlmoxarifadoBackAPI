using AlmoxarifadoDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmoxarifadoInfrastructure.Data.Interfaces
{
    public interface IItens_NotaRepository
    {
        List<ITENS_NOTA> ObterTodosOsItens();
        ITENS_NOTA ObterItensPorId(int id);

        ITENS_NOTA CriarItem(ITENS_NOTA itens);
    }
}
