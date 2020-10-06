using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balaskalaskalaskala
{
    class Program
    {

        public static char Menu()
        {
            return 'a';
        } 
        static void Main(string[] args)
        {
            Console.WriteLine("Mi lesz a karaktered neve?");
            string karakternev = Console.ReadLine();
            Console.WriteLine("Mi lesz a karaktered kasztja? \n1: Paladin \n2: Warrior \n3: Elf");
            int karakterkaszt = int.Parse(Console.ReadLine());
            Karakter jatekos = new Karakter(karakternev, karakterkaszt);

            //mindent megváltoztató komment
            Karakterek karakterekLista = new Karakterek("karakterek.txt");
            Kiiratas(karakterekLista);
            Console.ReadLine();
        }

        public static void Kiiratas(Karakterek karakterekLista)
        {

            
        }
    }
}
