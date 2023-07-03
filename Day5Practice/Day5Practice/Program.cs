namespace Day5Practice
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var i = 10;
            Console.WriteLine(i);
            Console.WriteLine(i.GetType());



            var o1 = new { Id = 10, Name = "aaa", Salary = 1.2 };
            Console.WriteLine(o1.Id);
            Console.WriteLine(o1.GetType());

        }
    }
}