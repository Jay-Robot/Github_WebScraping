﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GithubWebScraping.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GithubWebScrapping.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public String Get()
        {
            string url = "https://github.com/Jay-Robot/SD";
            WebScrapingService webScrapingService = new WebScrapingService();
            var dict = webScrapingService.StartScrap(url);

            return dict.ToString();
        }
    }
}
