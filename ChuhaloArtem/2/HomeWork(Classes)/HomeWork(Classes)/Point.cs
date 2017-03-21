using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Classes_
{
    class Point
    {
        int a, b;
        string name;

        public Point(int a, int b, string name)
        {
            this.a = a;            
            this.b = b;
            this.name = name;
        }

        public string GetName
        {
            get { return a+name; }
        }
        public int GetA
        {
            get { return a; }
        }
        public int GetB
        {
            get { return b; }
        }        
    }
}
