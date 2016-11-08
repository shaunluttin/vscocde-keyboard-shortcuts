namespace ConsoleApplication
{
    public class SomeClass
    {
        private readonly string _someProperty;

        public SomeClass(string someParameter)
        {
            _someProperty = someParameter;
        }

        public void WriteProperty()
        {
            System.Console.WriteLine(_someProperty);
        }
    }
}