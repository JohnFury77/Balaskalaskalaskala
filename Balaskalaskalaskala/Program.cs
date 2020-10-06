using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balaskalaskalaskala
{
    class Program
    {
        public static Karakter jatekos;
        public static char Menu()
        {
            char k = 'k';

            do
            {
                Console.WriteLine("'a' menüpont: Harcol\n'b' menüpont: Gyógyul\n'c' menüpont: Kilépés");
                k = char.Parse(Console.ReadLine());

            } while (k!='a'&& k != 'b'&& k != 'c');
            return char.ToLower(k);
        } 
        static void Main(string[] args)
        {
            Console.WriteLine("Üdvözlünk Temeriában.");
            Console.WriteLine("Mi lesz a karaktered neve?");
            string karakternev = Console.ReadLine();
            Console.WriteLine("Mi lesz a karaktered kasztja? \n1: Paladin \n2: Warrior \n3: Elf");
            int karakterkaszt = int.Parse(Console.ReadLine());
            
            jatekos = new Karakter(karakternev, karakterkaszt);
            Menu();
            //mindent megváltoztató komment
            Karakterek karakterekLista = new Karakterek("karakterek.txt");
            Kiiratas(karakterekLista);
            Console.ReadLine();
        }

        public static void Kiiratas(Karakterek karakterekLista)
        {
            
            int i = 1;
            foreach (Karakter k in karakterekLista.KarakterLista)
            {
                Console.WriteLine("#{0}\t"+k.ToString(),i);
                i++;
            }
            
        }
    }
}
