namespace masodfoku
{
    internal class Program
    {
        static int Reader()
        {
            int a;
            string input;
            do
            {
                Console.WriteLine("adj 1 szamot");
            } while (!int.TryParse(Console.ReadLine(), out a));

            return a;
        }

        static void Equu (int a, int b, int c, out double x1, out double x2 )
        {
            x1 = -((b + Math.Sqrt(b * b - 4 * a * c) / (2 * a)));
            x2 = -((b - Math.Sqrt(b * b - 4 * a * c) / (2 * a)));
        }

        static void Main(string[] args)
        {
            int a = Reader();
            int b = Reader();
            int c = Reader();

            double x1;
            double x2;
            Equu(a, b, c, out x1, out x2);

            Console.WriteLine("megoldasok: {0}, {1}" , x1 , x2);
            
        }
    }
}