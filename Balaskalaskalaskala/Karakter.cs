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
        int alapEletero;
        int alapSebzes;

        public Karakter(string nev, int statuszSablon)
        {
            this.nev = nev;
            this.szint = 1;
            this.tapasztalat = 0;
            
            switch (statuszSablon)
            {
                case 1:
                    this.alapEletero = 15;
                    this.alapSebzes = 3; 
                    break;
                case 2:
                    this.alapEletero = 12;
                    this.alapSebzes = 4; 
                    break;
                case 3:
                    this.alapEletero = 8;
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

        public string Nev
        {
            get
            {
                return this.nev;
            }

        }
        public int Szint
        {
            get
            {
                return this.szint;
            }
            set
            {
                this.szint=value;
            }
        }
        public int Tapasztalat
        {
            get
            {
                return this.tapasztalat;
            }
            set
            {
                this.tapasztalat = value;
            }
        }
        public int Eletero
        {
            get
            {
                return this.eletero;
            }
        }
        public int AlapEletero
        {
            get
            {
                return this.alapEletero;
            }
        }
        public int AlapSebzes
        {
            get
            {
                return this.alapSebzes;
            }
        }

    }
}
