namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var x = new FooBarClass("Dogs are higher maintenance than are cats.");
            x.WriteProperty();
        }
        
        public void Foo()
        {
            var x = 01;
            System.Console.WriteLine(x);
        }

        public void Bar()
        {

        }
    }
}
