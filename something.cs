namespace hello_world_csharp
{
    public class SomeClass
    {


        public SomeClass()
        {
            NewMethod();
        }

        private static string NewMethod()
        {
            string hellothere = NewMethod1();

            return hellothere;
        }

        private static string NewMethod1()
        {
            string hello = "Hello";
            string there = "there";

            string hellothere = hello + " " + there;
            return hellothere;
        }
    }
}