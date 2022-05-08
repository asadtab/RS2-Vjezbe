using eProdaja.Model.Requests;
using eProdaja.Model.Search_objects;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProizvodiController: BaseCRUDController<Model.Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>
    {

        public ProizvodiController(IProizvodiService proizvodiService): base(proizvodiService)
        {
        }


    }
}
