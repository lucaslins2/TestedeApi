using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestedeApi2.Model;

namespace TestedeApi2.Controllers
{
    [Authorize]
    [Route("api/v1/[controller]")]
    public class DashBoardController : Controller
    {

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(new
            {
                Catalogo = new CatalogoModel
                {
                    qtdetotal = 2,
                    qtdependente = 2,
                    qtdetransmissao = 0,
                    qtdetransmitido = 1
                },
                Produto = new ProdutoModel
                {
                    qtdetotal = 168,
                    qtdependente = 40,
                    qtdetransmissao = 128,
                    qtdetransmitido = 120
                },
                Atributo = new AtributoModel
                {
                    qtdetotal = 762,
                    qtdependente =75,
                    qtdetransmissao = 617,
                    qtdetransmitido = 0
                },
                Notificacoes = new NotificacaoModel
                {
                    qtde = 0

                }

            });
        }


    }
}
