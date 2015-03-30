using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Aggregate
{
    class Facebook : ISocialNetworking
    {
        private LinkedList<string> Users;

        public Facebook()
        {
            Users = new LinkedList<string>();
            Users.AddLast("Mike");
            Users.AddLast("Emir");
            Users.AddLast("Todd");
            Users.AddLast("John");
            Users.AddLast("Arnold");
            Users.AddLast("Alen");
        }

        public IIterator CreateIterator()
        {
            return new FacebookIterator(Users);
        }
    }
}
