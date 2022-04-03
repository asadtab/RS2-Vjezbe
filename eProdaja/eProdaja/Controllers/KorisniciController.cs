using eProdaja.Services;
using eProdaja.Services.Database;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController: ControllerBase
    {
        private readonly IKorisniciService _service;

        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Korisnici> Get()
        {
            return _service.Get();
        }
    }
}
