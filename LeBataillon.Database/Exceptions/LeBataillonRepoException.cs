using System;

namespace LeBataillon.Database.Exceptions
{
    public class LeBataillonRepoException : Exception
    {
        public string Property { get; set; }

        public LeBataillonRepoException(string property, string message) : base(message)
        {
            this.Property = property;
        }

        public LeBataillonRepoException(string message) : base(message)
        {
            this.Property = "";
        }

    }
}