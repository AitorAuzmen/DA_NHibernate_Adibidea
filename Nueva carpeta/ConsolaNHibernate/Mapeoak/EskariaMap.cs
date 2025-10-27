using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaNHibernate.Mapeoak
{
    internal class EskariaMap
    {
        {
            EskariaMap("Eskariak");
        EskariaMap(x => x.Id).GeneratedBy.Identity();
            EskariaMap(x => x.Data);
        EskariaMap(x => x.Zenbatekoa);

        EskariaMap(x => x.Erabiltzailea)
                .EskariaMap("erabiltzailea_id");
    }
}
}
