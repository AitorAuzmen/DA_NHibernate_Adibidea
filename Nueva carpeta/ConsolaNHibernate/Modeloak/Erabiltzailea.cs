using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaNHibernate.Modeloak
{
    public class Erabiltzailea
    {
        public virtual int Id { get; set; }
        public virtual string ErabiltzaileIzena { get; set; }
        public virtual string Izena { get; set; }
        public virtual string Emaila { get; set; }
       

        public virtual Helbidea Helbidea { get; set; }  // ONE TO ONE harremana

        public virtual IList<Eskaria> Eskariak { get; set; } = new List<Eskaria>(); // ONE TO MANY harremana



    }
}
