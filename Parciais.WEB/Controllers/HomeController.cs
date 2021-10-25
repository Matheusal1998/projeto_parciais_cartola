using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Parciais.WEB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Parciais.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
           var status =  await RetornarDados();

            return View(status);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        private async Task<Status> RetornarDados()
        {
            string URI = "https://api.cartolafc.globo.com/mercado/status";

            Status status = new Status();

            string agent = "ClientDemo/1.0.0.1 test user agent DefaultRequestHeaders";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", agent);

            using (var response = await client.GetAsync(URI))
            {
                if (response.IsSuccessStatusCode)
                {
                    var FuncionarioJsonString = await response.Content.ReadAsStringAsync();

                     status = JsonConvert.DeserializeObject<Status>(FuncionarioJsonString);

                    var fechamente =
                        status.fechamento.dia + "/" + status.fechamento.mes + "/" + status.fechamento.ano + " "
                        + status.fechamento.hora + ":" + status.fechamento.minuto;

                    DateTime dataFechamentoMercado = DateTime.Parse(fechamente);

                    status.FechamentoMercado = dataFechamentoMercado;
                }
            }

            return status;

        }
    }
}
