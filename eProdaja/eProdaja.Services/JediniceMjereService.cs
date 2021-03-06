    using AutoMapper;
using eProdaja.Model.Search_objects;
using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class JediniceMjereService: BaseService<Model.JediniceMjere, Database.JediniceMjere, JediniceMjereSearchObject>, IJediniceMjereService
    {
        public JediniceMjereService(eProdajaContext context, IMapper mapper): base (context, mapper)
        {
        }

        public override IQueryable<JediniceMjere> AddFilter(IQueryable<JediniceMjere> query, JediniceMjereSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrEmpty(search?.Naziv))
            {
                filteredQuery = filteredQuery.Where(x => x.Naziv == search.Naziv);
            }

            if(search?.JedinicaMjereID.HasValue == true)
            {
                filteredQuery = filteredQuery.Where(x => x.JedinicaMjereId == search.JedinicaMjereID);
            }

            return filteredQuery;
        }
    }
}
