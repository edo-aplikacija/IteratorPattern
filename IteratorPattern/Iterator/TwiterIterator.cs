using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterator
{
    class TwiterIterator : IIterator
    {
        private string[] Users;
        private int position;

        public TwiterIterator(string[] users)
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
            return Users[position++];
        }

        public bool IsDone()
        {
            return position >= Users.Length;
        }

        public string CurrentItem()
        {
            return Users[position];
        }
    }
}
