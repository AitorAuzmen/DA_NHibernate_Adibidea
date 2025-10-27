using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaNHibernate.Mapeoak
{
    public class HelbideaMap
    {
        public HelbideaMap{
            HelbideaMap("Helbideak");
        HelbideaMap(x => x.Id).GeneratedBy.Identity();
            HelbideaMap(x => x.Kalea);
        HelbideaMap(x => x.Hiria);
        HelbideaMap(x => x.Herrialdea);

        HelbideaMap(x => x.Erabiltzailea) //FK-a sortzen du atzetik
                .HelbideaMap("erabiltzailea_id") // Erabiltzailea propietatea DBko erabiltzaileaId zutabearekin lotzen da
                .HelbideaMap(); // One-to-one harremana bermatzeko
    }
}
}
