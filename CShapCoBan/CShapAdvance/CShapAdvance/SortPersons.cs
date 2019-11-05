﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CShapAdvance
{
    class SortPersons : IComparer
    {
        public int Compare(object x, object y)
        {
            Person p1 = x as Person;
            Person p2 = y as Person;

            if (p1 == null || p2 == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                if (p1.Age > p2.Age)
                {
                    return 1;
                }
                else if (p1.Age == p2.Age)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
