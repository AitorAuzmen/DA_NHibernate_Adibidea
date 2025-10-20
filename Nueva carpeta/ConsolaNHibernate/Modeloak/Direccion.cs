using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaNHibernate.Modeloak
{
    public class Direccion
    {
        public virtual int Idx { get; set; }
        public virtual string Calle { get; set; }
        public virtual string Ciudad { get; set; }
        public virtual string CodigoPostal { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
