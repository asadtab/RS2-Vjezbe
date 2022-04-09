using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class DummyProizvodiService : IProizvodiService
    {

        public DummyProizvodiService()
        {
             
        }

    public List<Model.Proizvodi> ProizvodiList = new List<Model.Proizvodi>() { new Model.Proizvodi() { ProizvodId = 1, Naziv = "Laptop" }, new Model.Proizvodi() { ProizvodId = 2, Naziv = "Racunar" }};


    public IEnumerable<Model.Proizvodi> Get()
        {

            ProizvodiList.Add(new Model.Proizvodi() { ProizvodId = 3, Naziv = "Test"});
            return ProizvodiList;
        }

        public Model.Proizvodi GetById(int id)
        {
            return ProizvodiList.FirstOrDefault(x => x.ProizvodId == id);
        }
    }
}
