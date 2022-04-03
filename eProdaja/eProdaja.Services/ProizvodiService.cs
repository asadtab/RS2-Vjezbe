using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodiService : IProizvodiService
    {
        public eProdajaContext Context { get; set; }

        public ProizvodiService(eProdajaContext context)
        {
            Context = context;
        }

    public List<Proizvodi> ProizvodiList = new List<Proizvodi>() { new Proizvodi() { ID = 1, Naziv = "Laptop" }, new Proizvodi() { ID = 2, Naziv = "Racunar" }};


    public IEnumerable<Proizvodi> Get()
        {
            var tmp = Context.Proizvodis.ToList();

            ProizvodiList.Add(new Proizvodi() { ID = 3, Naziv = "Test"});
            return ProizvodiList;
        }

        public Proizvodi GetById(int id)
        {
            return ProizvodiList.FirstOrDefault(x => x.ID == id);
        }
    }
}
