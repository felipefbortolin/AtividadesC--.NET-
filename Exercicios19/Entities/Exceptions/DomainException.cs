using System;

namespace Exercicio01.Entities.Exeptions
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message) { }
    }
}