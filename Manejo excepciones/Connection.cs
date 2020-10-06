using Manejo_excepciones.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_excepciones
{
    class Connection
    {
        private User user;
        private Server server;

        public Connection(User user, Server server)
        {
            this.user = user;
            this.server = server;

            EstablishConnection();
            
        }

        private void EstablishConnection()
        {
            try
            {
                bool connect = this.server.TryConnection();

                if(connect == false)
                {
                    throw new ErrorConnectionException(this.user.GetId(),"No se pudo establecer connecion con el servidor");

                }
            }
            catch (ErrorConnectionException e)
            {
                Console.WriteLine(e.Message);

                Console.WriteLine("Presione enter para salir");
                Console.ReadLine();
            }

        }
    }
}
