using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[11] { 0, 1, 2, 3, 4, 5, 6,7,8,9,10 };


            var numQuery =
                from num in numbers
                where num>5
                select num;

            foreach (int num in numQuery)
            {
                Console.WriteLine(num);
            }

            

            var evenNumQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            int evenNumCount = evenNumQuery.Count();
            Console.WriteLine(" Numero de numeros pares en el arreglo " + evenNumCount);






            //List<int> numQuery2 =
            //    (from num in numbers
            //     where (num % 2) == 0
            //     select num).ToList();

            //Console.Write(numQuery2); 
            

            //var numQuery3 =
            //    (from num in numbers
            //     where (num % 2) == 0
            //     select num).ToArray();

            //Console.Write(numQuery3); 





          List<Product>  products = getProducts();

            var soldOutProducts =
                from p in products
                where p.Cantidad == 0
                select p; 

            Console.WriteLine("Sold out products:");
            foreach (var product in soldOutProducts)
            {
                Console.WriteLine("{0} is sold out!", product.Nombre);
            } 


            ///
            List<Product> products3 = getProducts();

            var soldOutProducts3 =
                from p in products
                where p.Cantidad > 0 && p.Cantidad>2
                select p;

            Console.WriteLine("Productis ejemplo 3:");
            foreach (var product in soldOutProducts3)
            {
                Console.WriteLine("hay stock de  {0} y cuesta mas de 3", product.Nombre);
            }


            Linq5();
            Linq9();
            Linq14();
            Linq20();
            Linq22();
            Linq24();
            Console.ReadLine();
        }


        public class Product
        {

            private string NombreField;

            public string Nombre
            {
                get { return NombreField; }
                set { NombreField = value; }
            }

            private int CantidadField;
            //CTRL+R+E
            public int Cantidad
            {
                get { return CantidadField; }
                set { CantidadField = value; }
            }


        }


        public static List<Product> getProducts()
        {
           List<Product> products = new List<Product>();
            Product pro = new Product();
                    pro.Nombre="Producto 1";
                    pro.Cantidad=5;
    
            Product pro1 = new Product();
                    pro1.Nombre="Producto 2";
                    pro1.Cantidad=0;

            products.Add(pro);
            products.Add(pro1);

            return products;

        }


        public static void Linq5()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = digits.Where((digit, index) => digit.Length < index);

            Console.WriteLine("Short digits:");
            foreach (var d in shortDigits)
            {
                Console.WriteLine("The word {0} is shorter than its value.", d);
            }
        }



        public void Linq8()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var textNums =
                from n in numbers
                select strings[n];

            Console.WriteLine("Number strings:");
            foreach (var s in textNums)
            {
                Console.WriteLine(s);
            }
        }

        public static void Linq9()
        {
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
        

            var upperLowerWords =
                from w in words
                select new { Upper = w.ToUpper(), Lower = w.ToLower() };

            foreach (var ul in upperLowerWords)
            {
                Console.WriteLine("Uppercase: {0}, Lowercase: {1}", ul.Upper, ul.Lower);
            }
        }



        public static void Linq14()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var pairs =
                from a in numbersA
                from b in numbersB
                where a < b
                select new { a, b };

            Console.WriteLine("Pairs where a < b:");
            foreach (var pair in pairs)
            {
                Console.WriteLine("{0} is less than {1}", pair.a, pair.b);
            }
        }


        public static void Linq20()
        {

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };



            var first3Numbers = numbers.Take(4);



            Console.WriteLine("First 4 numbers:");

            foreach (var n in first3Numbers)
            {

                Console.WriteLine(n);

            }

        }


        public static void Linq22()
        {

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };



            var allButFirst4Numbers = numbers.Skip(4);



            Console.WriteLine("All but first 4 numbers:");

            foreach (var n in allButFirst4Numbers)
            {

                Console.WriteLine(n);

            }

        }


        public static void Linq24()
        {

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };



            var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);



            Console.WriteLine("First numbers less than 6:");

            foreach (var n in firstNumbersLessThan6)
            {

                Console.WriteLine(n);

            }

        }
       
    }
}
