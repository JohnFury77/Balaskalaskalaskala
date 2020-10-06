using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balaskalaskalaskala
{
    class Karakter
    {
        string nev;
        int szint;
        int tapasztalat;

        int eletero;
        int alapEro;
        int alapSebzes;

        public Karakter(string nev, int statuszSablon)
        {
            this.nev = nev;
            this.szint = 1;
            this.tapasztalat = 0;
            
            switch (statuszSablon)
            {
                case 1:
                    this.alapEro = 15;
                    this.alapSebzes = 3; 
                    break;
                case 2:
                    this.alapEro = 12;
                    this.alapSebzes = 4; 
                    break;
                case 3:
                    this.alapEro = 8;
                    this.alapSebzes = 5; 
                    break;
            }
           
            this.eletero = MaxEletero;
            
        }

        private int MaxEletero
        {
            get
            {
                return this.alapEro + szint * 5;
            }
        }
    }
}
