using System;

namespace hello_world_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass someClass = new SomeClass();
            Console.WriteLine(someClass.helloThere(42));
        }
    }
}
