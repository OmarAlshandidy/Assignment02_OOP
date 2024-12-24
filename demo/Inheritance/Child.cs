using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2.Inheritance
{
    internal class Child : Parent
    {
        public int Z { get; set; }
        public Child(int X , int Y, int Z):base(X,Y)
        {
            //this.X = X;
            //this.Y = Y;
            this.Z = Z;
        }
    }
}
