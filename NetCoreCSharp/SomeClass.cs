namespace ConsoleApplication
{
    public class FooBarClass
    {
        private readonly string _someProperty;

        public FooBarClass(string someParameter)
        {
            _someProperty = someParameter;
        }

        public void WriteProperty()
        {
            System.Console.WriteLine(_someProperty);
        }
    }
}