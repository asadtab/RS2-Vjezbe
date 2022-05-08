using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eProdaja.Model;
using eProdaja.Model.Search_objects;

namespace eProdaja.Services
{
    public interface IJediniceMjereService: IService<JediniceMjere, JediniceMjereSearchObject>
    {
        IEnumerable<JediniceMjere> Get(JediniceMjereSearchObject search); 
        JediniceMjere GetById(int id);

    }
}
