using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVector myVector = new MyVector(1.2,11,6);
            MyVector myVectorTwo = new MyVector(4, 3, 6.4);

            myVector.Init();
            myVectorTwo.Addition(myVector);
            myVector.Decrease(5.9);
            myVector.Increase(67);
            myVector.LenghtVector();
            myVectorTwo.angle(myVector);
            myVector.Equality(myVectorTwo);
            myVectorTwo.Equals(myVectorTwo);
            myVectorTwo.Multiplication(myVector);
            myVector.Prdouble();
            myVector.Subtraction(myVectorTwo);

        }
    }
}
