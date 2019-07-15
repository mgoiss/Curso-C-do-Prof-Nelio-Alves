using System;
using System.Collections.Generic;
using System.Text;

namespace Topico_11.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string messagem) : base(messagem)
        {
        }
    }
}
