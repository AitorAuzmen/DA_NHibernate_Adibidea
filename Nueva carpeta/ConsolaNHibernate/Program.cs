using ConsolaNHibernate.Modeloak;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaNHibernate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Erabiltzaile berriaren datuak eskatu
            Console.WriteLine("=== Erabiltzaile berria sartzea ===");
            Console.Write("Usuario: ");
            string usuario = Console.ReadLine();

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();


            Console.Write("Email: ");
            string email = Console.ReadLine();

            


            
            


            // Objektua sortu
            var nuevoUsuario = new Usuario
            {
                UsuarioNombre = usuario,
                Nombre = nombre,
                Email = email,
               
            };

            // NHibernate bidez gorde eta gero guztiak inprimatu
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                // 1️⃣ Gorde erabiltzaile berria
                session.Save(nuevoUsuario);
                transaction.Commit();
            }

            // 2️⃣ Guztiak inprimatu
            using (var session = NHibernateHelper.OpenSession())
            {
                var usuarios = session.Query<Usuario>().ToList();

                Console.WriteLine("\n=== Datu-baseko erabiltzaile guztiak ===");
                foreach (var u in usuarios)
                {
                    Console.WriteLine($"{u.Idx}: {u.Nombre} ({u.UsuarioNombre}) - Email: {u.Email}");
                }
            }

            Console.WriteLine("\nSakatu tekla bat amaitzeko...");
            Console.ReadKey();
        }
    }
}
