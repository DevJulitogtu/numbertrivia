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
    public class HomeController : Controller
    {
        public IActionResult Index() => Content("USING DOCKER HUB");

        public IActionResult About() => Content("@julitogtu - julitogtudev - julito_gtu@hotmail.com - ola ke ase  ");
    }
}