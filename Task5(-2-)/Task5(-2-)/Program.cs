namespace Task5__2__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var duzbucaqli_paralelepiped = new Duzbucaqlı_Paralelepiped(10, 20, 30);
            Console.WriteLine(duzbucaqli_paralelepiped);
            
            var konus = new konus(35, 30);
            Console.WriteLine(konus);
            var silndir = new silndir(35, 30);
            Console.WriteLine(silndir);
        }
    }
}