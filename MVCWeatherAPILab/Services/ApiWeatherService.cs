﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MVCWeatherAPILab.Services;
using MVCWeatherAPILab.Models;
using System.Text.Json;

namespace MVCWeatherAPILab.Services
{
    public class ApiWeatherService : IWeatherService
    {
        private readonly HttpClient _client;

        public ApiWeatherService(HttpClient client)
        {
            _client = client;
        }

        public async Task<Weather> GetAll()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true
            };
            var response = await _client.GetFromJsonAsync<Weather>("MapClick.php?lat=38.4247341&lon=-86.9624086&FcstType=json", options);
            return response;
        }
    }
}