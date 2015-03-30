using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Aggregate
{
    class Twitter : ISocialNetworking
    {
        private string[] Users;

        public Twitter()
        {
            Users = new string[] { "Adi", "Adi", "Amira", "Adrian", "Alem" };
        }

        public IIterator CreateIterator()
        {
            return new TwiterIterator(Users);
        }
    }
}
