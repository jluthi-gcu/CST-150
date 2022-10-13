using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity10
{
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
                //This exited the loop to soon which caused the value to not be checked against all elements and allowed for duplicates to exist in the set.
                //else
                //    return false;
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {
            //This was wrong because it should instead iterate through the indexes of the current instanced object (this)
            //instead of the the object passed in so that new elements may be added to the passed in object from the current object.
            //for (int i = 0; i < rhs.elements.Count; i++)
            for (int i = 0; i < this.elements.Count; i++)
            {
                //The instance of the current object (this) should not change but rather elements should be added to the 
                //passed in object which has no effect on the orignial objects invoking this method call because it was passed by value and not by reference.
                //this.addElement(rhs.elements[i]);
                rhs.addElement(this.elements[i]);
            }
            return rhs;
        }


    }

}
