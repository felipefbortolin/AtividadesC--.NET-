using System;

namespace Exercicio02.Entities.Exeptions
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message) { }
    }
}