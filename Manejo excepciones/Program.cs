using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_excepciones
{
    class Program
    {
        public static Server server = new Server();
        static void Main(string[] args)
        {
            // INICIO DE SESION

            Console.WriteLine("INICIO DE SESION");
            Console.WriteLine("\nUsuario:");
            string user = Console.ReadLine();
            Console.WriteLine("\nContraseña:");
            string password = Console.ReadLine();

            int id = server.GetUsers().Count;

            User user1 = new User(id, user, password);

            Connection connection = new Connection(user1, server);

        }
    }
}
