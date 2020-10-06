using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_excepciones
{
    //SIMULACION DE SERVIDOR
    class Server
    {
        private List<User> users;
        
        public Server()
        {
            this.users = new List<User>();
        }

        public List<User> GetUsers()
        {
            return this.users;
        }

        public bool TryConnection()
        {
            return false;
        }
    }
}
