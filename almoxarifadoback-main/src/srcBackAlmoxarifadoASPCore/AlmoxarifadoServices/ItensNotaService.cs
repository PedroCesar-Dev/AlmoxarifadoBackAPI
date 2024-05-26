using AlmoxarifadoDomain.Models;
using AlmoxarifadoInfrastructure.Data.Interfaces;
using AlmoxarifadoServices.DTO;
using AutoMapper;

namespace AlmoxarifadoServices
{
    public class ItensNotaService
    {
        private readonly IItens_NotaRepository _ItemNotaRepository;
        private readonly MapperConfiguration configurationMapper;

        public ItensNotaService(IItens_NotaRepository iten_notaRepository)
        {
            _ItemNotaRepository = iten_notaRepository;
            configurationMapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ITENS_NOTA, Itens_NotaGetDTO>();
                cfg.CreateMap<Itens_NotaGetDTO, ITENS_NOTA>();
            });
        }
        public List<Itens_NotaGetDTO> ObterTodosOsItens()
        {
            var mapper = configurationMapper.CreateMapper();
            return mapper.Map<List<Itens_NotaGetDTO>>(_ItemNotaRepository.ObterTodosOsItens());
        }
        public ITENS_NOTA ObterItensPorId(int id)
        {
            return _ItemNotaRepository.ObterItensPorId(id);
        }
        public Itens_NotaGetDTO CriarItem(Itens_NotaPostDTO item)
        {
            var itemSalvo = _ItemNotaRepository.CriarItem( 
                new ITENS_NOTA
                {

                    ITEM_NUM = item.,
                    ID_PRO = item.ID_PRO,
                    ID_NOTA = item.ID_NOTA,
                    ID_SEC = item.ID_SEC,
                    QTD_PRO = item.QTD_PRO,
                    PRE_UNIT = item.PRE_UNIT,
                    TOTAL_ITEM = item.TOTAL_ITEM,
                    EST_LIN = item.EST_LIN
                }
                );
        }
    }
}
