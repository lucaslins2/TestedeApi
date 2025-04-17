using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TestedeApi2.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/v1/[controller]")]
    public class ProdutosController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get()
        {
            var lista = new[]
            {
                new {
                    codigo = 542,
                    tipo = "Catálogo IMP",
                    descricao = "Ventilador de Mesa",
                    codigoItem = "VTL34MS",
                    ncm = "8414.51.10",
                    statusTransmissao = "Transmitido",
                    statusAtivacao = "Ativado",
                    dataHora = "14-04-2025 - 10:26"
                },
                new {
                    codigo = 542,
                    tipo = "Catálogo IMP",
                    descricao = "Válvula Redutora",
                    codigoItem = "VL75RAW",
                    ncm = "8481.10.00",
                    statusTransmissao = "Transmitido",
                    statusAtivacao = "Ativado",
                    dataHora = "14-04-2025 - 10:26"
                },
                new {
                    codigo = 542,
                    tipo = "Catálogo IMP",
                    descricao = "Limpador Para-Brisa",
                    codigoItem = "LPD20MM",
                    ncm = "8479.89.31",
                    statusTransmissao = "Transmitido",
                    statusAtivacao = "Ativado",
                    dataHora = "14-04-2025 - 10:26"
                },
                new {
                    codigo = 542,
                    tipo = "Catálogo IMP",
                    descricao = "Kit Manutenção",
                    codigoItem = "KTM3RSW",
                    ncm = "8486.90.00",
                    statusTransmissao = "Transmitido",
                    statusAtivacao = "Ativado",
                    dataHora = "14-04-2025 - 10:26"
                },
                new {
                    codigo = 542,
                    tipo = "Catálogo IMP",
                    descricao = "Batom Marsala",
                    codigoItem = "BT32CSL",
                    ncm = "3304.10.00",
                    statusTransmissao = "Transmitido",
                    statusAtivacao = "Ativado",
                    dataHora = "14-04-2025 - 10:26"
                }
            };

            return Ok(lista);
        }

        [HttpGet("pesquisar")]
        public IActionResult Pesquisar(string descricaoProduto)
        {
            var lista = new[]
            {
        new {
            codigo = 542,
            tipo = "Catálogo IMP",
            descricao = "Ventilador de Mesa",
            codigoItem = "VTL34MS",
            ncm = "8414.51.10",
            statusTransmissao = "Transmitido",
            statusAtivacao = "Ativado",
            dataHora = "14-04-2025 - 10:26"
        },
        new {
            codigo = 542,
            tipo = "Catálogo IMP",
            descricao = "Válvula Redutora",
            codigoItem = "VL75RAW",
            ncm = "8481.10.00",
            statusTransmissao = "Transmitido",
            statusAtivacao = "Ativado",
            dataHora = "14-04-2025 - 10:26"
        },
        new {
            codigo = 542,
            tipo = "Catálogo IMP",
            descricao = "Limpador Para-Brisa",
            codigoItem = "LPD20MM",
            ncm = "8479.89.31",
            statusTransmissao = "Transmitido",
            statusAtivacao = "Ativado",
            dataHora = "14-04-2025 - 10:26"
        }
    };

            var resultado = lista.Where(item => item.descricao.Contains(descricaoProduto, StringComparison.OrdinalIgnoreCase)).ToList();

            return Ok(resultado);
        }




    }
}
