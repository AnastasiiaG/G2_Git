using System;

namespace Solution_G2
{
    class Program
    {
        static void Main(string[] args)
        {
            ParentClass parentClass = new ParentClass();
            parentClass.myBool = true;
            //Console.WriteLine(parentClass.myBool);



            ChildClass childClass = new ChildClass();
            //Console.WriteLine(childClass.childInt);

            ParentClass parentClass1 = new ChildClass();

            //Impossible
            //childClass = ChildClass(ParentClass);
            // Console.WriteLine(childClass.childInt);

            childClass.TestMethod();
            Console.ReadKey();

        }
    }
}
