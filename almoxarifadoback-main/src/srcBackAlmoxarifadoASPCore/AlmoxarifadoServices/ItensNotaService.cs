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
                cfg.CreateMap<Itens_NotaPutDTO, ITENS_NOTA>();
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

                    ITEM_NUM = item.ITEM_NUM,
                    ID_PRO = item.ID_PRO,
                    ID_NOTA = item.ID_NOTA,
                    ID_SEC = item.ID_SEC,
                    QTD_PRO = item.QTD_PRO,
                    PRE_UNIT = item.PRE_UNIT,
                    TOTAL_ITEM = item.TOTAL_ITEM,
                    EST_LIN = item.EST_LIN
                });
            return new Itens_NotaGetDTO
            {
                ITEM_NUM = itemSalvo.ITEM_NUM,
                ID_PRO = itemSalvo.ID_PRO,
                ID_NOTA = itemSalvo.ID_NOTA,
                ID_SEC = itemSalvo.ID_SEC,
                QTD_PRO = itemSalvo.QTD_PRO,
                PRE_UNIT = itemSalvo.PRE_UNIT,
                TOTAL_ITEM = itemSalvo.TOTAL_ITEM,
                EST_LIN = itemSalvo.EST_LIN
            };
        }

        public bool AtualizarItem(int id, Itens_NotaPutDTO itemDto)
        {
            var existingItem = _ItemNotaRepository.ObterItensPorId(id);
            if (existingItem == null)
            {
                return false;
            }

            var mapper = configurationMapper.CreateMapper();
            var updatedItem = mapper.Map(itemDto, existingItem);
            _ItemNotaRepository.AtualizarItem(updatedItem);

            return true;
        }

        public bool DeletarItem(int id)
        {
            var existingItem = _ItemNotaRepository.ObterItensPorId(id);
            if (existingItem == null)
            {
                return false;
            }

            _ItemNotaRepository.DeletarItem(id);
            return true;
        }
    }
}
