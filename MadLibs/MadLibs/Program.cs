using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            String color;
            String WordEst;
            String bodyPartPlural;
            String anAnimal;
            String noun;
            String pluralNoun;
            int a;
            int b;
            int c;

            Console.WriteLine("What is your color >>> " );
            color = Console.ReadLine();

            Console.WriteLine("Enter a word ending in EST >>> ");
            WordEst = Console.ReadLine();

            Console.WriteLine();
            bodyPartPlural = Console.ReadLine();

            Console.WriteLine();
            anAnimal = Console.ReadLine();

            Console.WriteLine();
            noun = Console.ReadLine();

            Console.WriteLine();
            pluralNoun = Console.ReadLine();


            Console.WriteLine("Enter a number >>>" );
            a = Convert.ToInt32(Console.ReadLine());
           

            Console.WriteLine("Enter another number but smaller than the first >>>");
            b = Convert.ToInt32(Console.ReadLine());
            c = a - b;


         
            Console.WriteLine("The {0} Dragon is the " + "{1} Dragon of all. It has {2} {3}, and a {4} shaped like a {5}. It loves to " + "eat {6} although it will feast on nearly anything" , color, WordEst, c, bodyPartPlural, anAnimal,noun,pluralNoun);
        }
    }
}
