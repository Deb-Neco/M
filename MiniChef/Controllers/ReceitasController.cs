using Microsoft.AspNetCore.Mvc;
using MiniChef.Domain.IService;
using MiniChef.Domain.Model;
using MiniChef.Service;
using System;


namespace MiniChef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitasController : ControllerBase
    {
        private IReceitasService _service;

        public ReceitasController(IReceitasService service)
        {
            _service = service;
        }


        
    }


}

