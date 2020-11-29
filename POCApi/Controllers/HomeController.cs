using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using POCWeb.Models;
using RazorLight;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace POCApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IConverter _pdfConverter;

        public HomeController(IConverter pdfConverter)
        {
            _pdfConverter = pdfConverter;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)],
                BaseUrl = "http://localhost:55213"
            })
            .ToArray();
        }

        [Route("PrintPDF")]
        public async Task<byte[]> PrintPDFAsync()
        {
            var engine = new RazorLightEngineBuilder()
                            .UseFileSystemProject(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location))
                            .UseMemoryCachingProvider()
                            .Build();

            var model = new List<WeatherForecast>(Get());
            string page = null;
            try
            {
                var path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), $"Views/Home/Index.cshtml");
                page = await engine.CompileRenderAsync(path, model);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Landscape,
                    PaperSize = PaperKind.A4Plus
                },
                Objects = {
                    new ObjectSettings() {
                        PagesCount = true,
                        HtmlContent = page,
                        UseExternalLinks = true,
                        UseLocalLinks = true,
                        WebSettings = { DefaultEncoding = "utf-8" },
                        HeaderSettings = { FontSize = 9, Right = "Page [page] of [toPage]", Line = true, Spacing = 2.812 }
                    }
                }
            };

            byte[] pdf = null;
            try
            {
                pdf = _pdfConverter.Convert(doc);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return pdf;
        }
    }
}
