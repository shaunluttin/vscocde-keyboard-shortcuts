namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var x = new FooBarClass("Dogs are higher maintenance than are cats.");
            x.WriteProperty();

            var choc = 0;
            FooBarBaz(out choc);

            // bad thing to do
            // because it defeats all tree shaking
            // at the assembly level
            System.Console.WriteLine((BadThingToDo() as dynamic).a);
        }

        public void Foo()
        {
            var x = 35;
            System.Console.WriteLine(x);
        }

        public static void FooBarBaz(out int chocolate)
        {
            chocolate = 23;
        }

        public static object BadThingToDo()
        {
            return new {
                a = 10
            };
        }
    }
}
