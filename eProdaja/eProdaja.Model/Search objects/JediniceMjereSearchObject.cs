using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model.Search_objects
{
    public class JediniceMjereSearchObject: BaseSearchObject
    {
        public string Naziv { get; set; }
        public int? JedinicaMjereID { get; set; }
    }
}
