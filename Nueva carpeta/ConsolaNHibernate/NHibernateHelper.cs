using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ConsolaNHibernate.Modeloak;

namespace ConsolaNHibernate
{
   
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using NHibernate;
    using NHibernate.Tool.hbm2ddl;
    using ConsolaNHibernate.Mapeoak;

    public static class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InitializeSessionFactory();
                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(
                    MySQLConfiguration.Standard
                        .ConnectionString(cs => cs
                            .Server("localhost")
                            .Database("datu atzipena")
                            .Username("root")
                            .Password("1MG2024")
                        )
                )
                .Mappings(m =>
                    m.FluentMappings.AddFromAssemblyOf<ErabiltzaileaMap>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(false, true)) 
                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }

    public class DireccionMap : ClassMap<Helbidea>
    {
        public DireccionMap()
        {
            Table("direcciones"); // actual table name
            Id(x => x.Id).Column("idx").GeneratedBy.Identity();
            Map(x => x.Kalea).Column("Kalea");
            Map(x => x.Hiria).Column("Hiria");
            Map(x => x.Herrialdea).Column("Herrialdea");

            // FK to Usuario table. Make it unique if it's strictly one-to-one.
            References(x => x.Erabiltzailea)
                .Column("usuario_idx")
                .Unique()
                .Not.Nullable(); 
        }
    }
}

