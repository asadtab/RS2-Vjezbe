using eProdaja.Model;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JediniceMjereController : ControllerBase
    {
        private readonly IJediniceMjereService _jedinicaMjereService;

        public JediniceMjereController(IJediniceMjereService proizvodiService)
        {
            _jedinicaMjereService = proizvodiService;
        }

        [HttpGet]   
        public IEnumerable<JediniceMjere> Get()
        {
            return _jedinicaMjereService.Get();
        }
        [HttpGet("{id}")]
        public JediniceMjere GetById(int id)
        {
            return _jedinicaMjereService.GetById(id);
        }
    }
}
