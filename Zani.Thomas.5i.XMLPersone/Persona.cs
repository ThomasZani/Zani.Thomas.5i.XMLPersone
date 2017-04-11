using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Xml.Linq;

namespace Zani.Thomas._5i.XMLPersone
{
    class Persona
    {
        public string Nome {get;set;}
        public string Cognome { get; set;}
        public string Indirizzo { get; set; }
        public string Numero { get; set; }

        public Persona (XElement e)
        {
            Nome = e.Attribute("nome").Value;
            Cognome = e.Attribute("cognome").Value;
            Indirizzo = e.Attribute("indirizzo").Value;
            Numero = e.Attribute("numero").Value;
        }
    }
}
