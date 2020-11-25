using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using POCWeb.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace POCWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: WeatherForecasts
        public async Task<IActionResult> Index()
        {
            IEnumerable<WeatherForecast> weatherForecasts = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55237/");
                //HTTP GET
                var responseTask = await client.GetAsync("Home");
                if (responseTask.IsSuccessStatusCode)
                {

                    var read = await responseTask.Content.ReadAsStringAsync();
                    weatherForecasts = JsonConvert.DeserializeObject<IEnumerable<WeatherForecast>>(read);
                    return View(weatherForecasts);
                }
            }
            return View(weatherForecasts);
        }

        public async Task<IActionResult> PrintPDFAsync()
        {
            byte[] file = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55237/Home/");
                HttpResponseMessage responseTask = await client.GetAsync("PrintPDF");
                if (responseTask.IsSuccessStatusCode)
                {
                    string response = responseTask.Content.ReadAsStringAsync().Result.Replace("\"", string.Empty);
                    file = Convert.FromBase64String(response);
                }
            }

            //wrtite to desk for testing
            //using (FileStream stream = new FileStream(@"C:\" + DateTime.UtcNow.Ticks.ToString() + ".pdf", FileMode.Create))
            //{
            //    stream.Write(file, 0, file.Length);
            //}

            return File(file, "application/pdf", "sample.pdf");
        }
    }
}
