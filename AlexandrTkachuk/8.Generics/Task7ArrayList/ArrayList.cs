using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7ArrayList
{
    class ArrayList
    {
        object[] values;
        int count;

        public int Count
        {
            get { return count; }
        }

        public ArrayList()
        {
            values = new object[0];
            count = 0;
        }

        public ArrayList(int count)
        {
            values = new object[count];
            this.count = count;
        }

        public object this[int index] 
        {
            get { return values[index]; }
            set { values[index] = value; }
        }


        public void Add(object AddedValue)
        {
            object [] temoraryArray = new object[count+1];
            for (int i = 0; i < count; i++)
            {
                temoraryArray[i] = values[i];
            }
            temoraryArray[count] = AddedValue;
            values = temoraryArray;
            count++;
        }

    }
}
