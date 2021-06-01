using System;
using System.Linq;
using System.Text;

namespace M3OO
{
    class Program
    {
        static void Main(string[] args)
        {
            ISomethingDoer a = new A();
            ISomethingDoer b = new B();
            var keyInfo = Console.ReadKey();
            ISomethingDoer selected = keyInfo.Key == ConsoleKey.A ? a : b;
            selected.DoSomething();
            //selected.DoAnotherThing();

        }


        private static Product[] _products = new Product[]
        {
            new Product(
                "Philips 58\" The One 58PUS8505 (2020)",
                "Ambilight, Android TV, Ultra HD(4K), Dolby Vision, Dolby Atmos, HDR10+, P5, Swiv",
                1161431,
                5,
                6990,
                "Philips"),
            new Product(
                "Samsung Soundbar HW-Q900T/XE",
                "7.1.2Ch, Dolby ATMOS, Subwoofer, Q-Symphony, Adaptive Sound, Bulit-in voice ass",
                1163445 ,
                4,
                5490,
                "Samsung"),
            new Product(
                "Komplett Khameleon P9 Bærbar Gaming PC",
                "15,6\" 144Hz, GeForce GTX 1660Ti, Core i7-9750H, 16GB, 1TB SSD, Wifi6, Win10Home",
                1147203 ,
                3,
                9999,
                "Komplett"),
        };


        static void MainLinq(string[] args)
        {
            /*
             * filter (Seleksjon i SQL)
             * map (Projeksjon i SQL)
             * aggregering (min, max, sum, snitt)
             * søke/slå opp
             */

            //var products = _products.Where(CheaperThan7000);
            var products = _products.Where(p => p.Price < 7000);

            var prices = _products.Select(p => p.Price);
            Console.WriteLine(string.Join(' ', prices));
            var pageIndex = 1;
            var pageSize = 10;
            var prices2 = _products
                .Where(p => p.Price < 7000)
                .Where(p => p.Rating >= 4)
                .Skip(pageIndex * pageSize)
                .Take(10)

                ;
            //.Where(p => p.Price < 7000 && p.Rating >= 4)
            //.Select(p => p.Price);
        }

        private static bool CheaperThan7000(Product p)
        {
            return p.Price < 7000;
        }

        static void ExtMethDemo(string[] args)
        {
            var product = _products[0];
            MyExtensions.Show(product);
            product.Show();

        }
        static void Main2(string[] args)
        {
            //var htmlBuilder = new HtmlBuilder();
            //htmlBuilder.Add("h1", "Velkommen");
            //htmlBuilder.Add("p", "Bla bla bla.");
            //var html = htmlBuilder.Html;

            var html = new HtmlBuilder()
                .Add("h1", "Velkommen")
                .Add("p", "Bla bla bla.")
                .Html;
            Console.WriteLine(html);

            //var sb = new StringBuilder();
            //sb.AppendJoin()
            var txt = new StringBuilder()
                .AppendLine("Hei på deg!")
                .AppendLine("Hei på deg!")
                .AppendLine("Hei")
                .Remove(10, 10)
                .AppendLine("Hei")
                .ToString();
            Console.WriteLine(txt);

        }
        static void Main1(string[] args)
        {
            var nextDirection = new Dictionary();
            nextDirection.Add("up", "right");
            nextDirection.Add("right", "down");
            nextDirection.Add("down", "left");
            nextDirection.Add("left", "up");

            var direction = "up";
            Console.WriteLine(direction);
            direction = nextDirection.Get(direction);
            Console.WriteLine(direction);
            direction = nextDirection.Get(direction);
            Console.WriteLine(direction);
            direction = nextDirection.Get(direction);
            Console.WriteLine(direction);
            direction = nextDirection.Get(direction);
            Console.WriteLine(direction);
        }
    }
}
