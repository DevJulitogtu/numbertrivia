using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using api.Dto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace api.Controllers
{
    [Route("api/trivia")]
    public class TriviaController : Controller
    {
        [HttpGet("{number}")]
        public async Task<TriviaResponse> GetAsync(int number)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"http://numbersapi.com/{number}?json");
            var triviaResult = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<TriviaResponse>(triviaResult);
        }

        [HttpGet()]
        public string GetUpperName()
        {
            return "TESTING ASPNET CORE + GITHUB + DOCKER + VSTS + AZURE";
        }
    }
}
