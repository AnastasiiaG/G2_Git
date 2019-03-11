using System;

namespace Solution_G2
{
    public class ParentClass
    {
       public bool myBool = true;
        public int myInt = 134;
        public byte myByte = 10;
        public char myChar = 'A';


        public virtual void TestMethod()
        {
            Console.WriteLine("Parent class");
        }
    }
}
