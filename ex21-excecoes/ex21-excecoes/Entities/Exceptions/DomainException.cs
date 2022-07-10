using System;

namespace ex21_excecoes.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        /* O construtor DomainException recebe uma mensagem
         * e a repassa para a superclasse ApplicationException. */
        public DomainException(string message) : base(message)
        {
        }
    }
}
