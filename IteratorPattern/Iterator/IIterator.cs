﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterator
{
    public interface IIterator
    {
        void First(); // Reset back to first Iterator
        string Next(); // Get next
        bool IsDone(); // End of collection check
        string CurrentItem(); // Get current item
    }
}
