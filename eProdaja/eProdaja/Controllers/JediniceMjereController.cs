using eProdaja.Model;
using eProdaja.Model.Search_objects;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{

    public class JediniceMjereController : BaseController<Model.JediniceMjere, JediniceMjereSearchObject>
    {
        public JediniceMjereController(IJediniceMjereService service):base(service)
        {
        }
    }
}
