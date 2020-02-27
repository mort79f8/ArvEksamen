using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvEksamen
{
    public class SkriftligEksamen : Eksamen
    {
        private string hjælpeMiddel;

        public SkriftligEksamen(char nieveau, bool havePass, int karakter, int eksaminationstid, string hjælpeMiddel) : base(nieveau, havePass, karakter, eksaminationstid)
        {
            HjælpeMiddel = hjælpeMiddel;
        }

        public string HjælpeMiddel { get => hjælpeMiddel; set => hjælpeMiddel = value; }

        //  retunere det antal ekesamner som der kan være på en dag
        public override int AntalEksamPrDag()
        {
            int value = 0;

            while ((value * (Eksaminationstid/6+10) < 444))
            {
                value++;
            }

            return value - 1;
        }
    }
}
