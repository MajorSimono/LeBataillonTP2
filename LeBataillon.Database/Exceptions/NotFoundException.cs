
using System;

namespace LeBataillon.Database.Exceptions
{

    public class NotFoundException : LeBataillonRepoException
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}