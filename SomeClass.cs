namespace hello_world_csharp
{
    public class SomeClass
    {
        public int myProp { get; set; }

        public SomeClass()
        {
        }

        public string helloThere(int someNumber)
        {
            int x = someNumber;
            string hellothere = privateHello(x);
            return hellothere;
        }

        private string privateHello(int x)
        {
            string hello = "Hello";
            string there = "there";

            string hellothere = hello + " " + there;
            return hellothere + x.ToString();
        }
    }
}