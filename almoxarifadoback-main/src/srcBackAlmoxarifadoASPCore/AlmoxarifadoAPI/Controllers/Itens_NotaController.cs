using AlmoxarifadoDomain.Models;
using AlmoxarifadoServices;
using AlmoxarifadoServices.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Itens_NotaController : ControllerBase
    {
        private readonly ItensNotaService _itensNotaService;
        public Itens_NotaController(ItensNotaService itensNotaService)
        {
            _itensNotaService = itensNotaService;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var itens = _itensNotaService.ObterTodosOsItens();
                return Ok(itens);
            }
            catch (Exception)
            {

                return StatusCode(500, "Ocorreu um erro ao acessar os dados. Por favor, tente novamente mais tarde.");
            }
        }

        [HttpGet("/ITENS_NOTA/{id}")]
        public IActionResult GetPorID(int id)
        {
            try
            {
                var itens = _itensNotaService.ObterItensPorId(id);
                if (itens == null)
                {
                    return StatusCode(404, "Nenhum item Encontrado com Esse Codigo");
                }
                return Ok(itens);
            }
            catch (Exception)
            {

                return StatusCode(500, "Ocorreu um erro ao acessar os dados. Por favor, tente novamente mais tarde.");
            }
        }

        [HttpPost]
        public IActionResult CriarItem(Itens_NotaPostDTO item)
        {
            try
            {
                var itemSalvo = _itensNotaService.CriarItem(item);
                return Ok(itemSalvo);
            }
            catch (Exception)
            {

                return StatusCode(500, "Ocorreu um erro ao acessar os dados. Por favor, tente novamente mais tarde.");
            }
        }

        [HttpPut("/ITENS_NOTA/{id}")]
        public IActionResult Atualizar(int id, [FromBody] Itens_NotaPutDTO itemAtualizado)
        {
            try
            {
                var itemAtualizadoComSucesso = _itensNotaService.AtualizarItem(id, itemAtualizado);
                if (!itemAtualizadoComSucesso)
                {
                    return NotFound("Item não encontrado para atualização.");
                }
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocorreu um erro ao atualizar o item. Por favor, tente novamente mais tarde.");
            } 
        }

        [HttpDelete("/ITENS_NOTA/{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                var itemDeletadoComSucesso = _itensNotaService.DeletarItem(id);
                if (!itemDeletadoComSucesso)
                {
                    return NotFound("Item não encontrado para exclusão.");
                }
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocorreu um erro ao excluir o item. Por favor, tente novamente mais tarde.");
            }
        }
    }
}
