using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvEksamen
{
    public abstract class Eksamen
    {
        private char nieveau;
        private bool havePass;
        private int karakter;
        private int eksaminationstid;

        protected Eksamen(char nieveau, bool havePass, int karakter, int eksaminationstid)
        {
            Nieveau = nieveau;
            HavePass = havePass;
            Karakter = karakter;
            Eksaminationstid = eksaminationstid;
        }

        public char Nieveau { get => nieveau; set => nieveau = value; }
        public bool HavePass { get => havePass; set => havePass = value; }
        public int Karakter { get => karakter; set => karakter = value; }
        public int Eksaminationstid { get => eksaminationstid; set => eksaminationstid = value; }

        // returns a tuple that show true or false depending if the person passed the exame and the grade.
        public (bool bestået, int karakter ) bedømmelsesform
        {
            get
            {
                return (HavePass, Karakter);
            }
        }

        public abstract int AntalEksamPrDag();

    }
}
