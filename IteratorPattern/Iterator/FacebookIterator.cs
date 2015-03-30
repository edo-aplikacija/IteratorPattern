using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterator
{
    class FacebookIterator : IIterator
    {
        private LinkedList<string> Users;
        private int position;

        public FacebookIterator(LinkedList<string> users)
        {
            this.Users = users;
            this.position = 0;
        }

        public void First()
        {
            this.position = 0;
        }

        public string Next()
        {
            return Users.ElementAt(position++);
        }

        public bool IsDone()
        {
            return position >= Users.Count;
        }

        public string CurrentItem()
        {
            return Users.ElementAt(position);
        }
    }
}
