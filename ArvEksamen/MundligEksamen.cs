using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvEksamen
{
    public class MundligEksamen : Eksamen
    {
        private int forberedelsestid;
        private string hjælpMiddel;
        public MundligEksamen(char nieveau, bool havePass, int karakter, int eksaminationstid, int forberedelsestid, string hjæleMiddel) : base(nieveau, havePass, karakter, eksaminationstid)
        {
            Forberedelsestid = forberedelsestid;
            HjælpMiddel = hjælpMiddel;
        }

        public int Forberedelsestid { get => forberedelsestid; set => forberedelsestid = value; }
        public string HjælpMiddel { get => hjælpMiddel; set => hjælpMiddel = value; }

        //  retunere det antal ekesamner som der kan være på en dag
        public override int AntalEksamPrDag()
        {
            int value = 0;

            while ((value * Eksaminationstid + Forberedelsestid + 30) < 444 )
            {
                value++;               
            }

            return value-1;
        }
    }
}
