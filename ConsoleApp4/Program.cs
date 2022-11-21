using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[50];
            int n, i, elem, pos = 0;
            Console.Write("Taille du tableau = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("inserer les elements dans un ordre croissant:\n", n);

            for (i = 0; i < n; i++)
            {
                Console.Write("element {0} : ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Element a inserer : ");
            elem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Avant ajout :\n ");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", tab[i]);
            /*position adequate*/
            for (i = 0; i < n; i++)
                if (elem < tab[i])
                {
                    pos = i;
                    break;
                }
            /* decaler les donnes*/
            for (i = n; i >= pos; i--)
                tab[i] = tab[i - 1];
            /* inserer l'element dans sa propre position*/
            tab[pos] = elem;
            Console.Write("\nAprès ajout" +
                ":\n ");
            for (i = 0; i <= n; i++)
                Console.Write("{0} ", tab[i]);
            Console.Write("\n");
            Console.ReadLine();
        }
    }
}