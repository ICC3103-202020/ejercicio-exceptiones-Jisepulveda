using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_excepciones
{
    class User
    {
        private int id;
        private string name;
        private string password;
        private DateTime lastConnection;

        public User(int id, string name, string password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.lastConnection = DateTime.Now;
        }

        public int GetId()
        {
            return this.id;
        }

    }
}
