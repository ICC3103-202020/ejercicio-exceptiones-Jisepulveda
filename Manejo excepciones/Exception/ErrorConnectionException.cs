using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_excepciones.Exception
{
    public class ErrorConnectionException : ApplicationException
    {
        private readonly int idUser;

        public ErrorConnectionException(int idUser, string message) : base(message)
        {
            this.idUser = idUser;
        }

    }
}
