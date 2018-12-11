using Coin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Coin.Controllers
{
    public class HomeController : Controller
    {

        HttpClient client = new HttpClient();
        public async Task<ActionResult> Index()
        {
            CoinBorsa coinBorsa = null;
            HttpResponseMessage response = await client.GetAsync("https://koineks.com/ticker");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                coinBorsa = JsonConvert.DeserializeObject<CoinBorsa>(json);
            }
            ViewBag.coinBorsa = coinBorsa;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Crypto()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Comments()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult BlogSingle()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}