using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvEksamen
{
    public class ProjectEksamen : Eksamen
    {
        private int maxGruppeStørrelse;
        private int maxSider;
        private char projektForsvar;
        public ProjectEksamen(char nieveau, bool havePass, int karakter, int eksaminationstid, int maxGruppeStørrelse, int maxSider, char projektForsvar) : base(nieveau, havePass, karakter, eksaminationstid)
        {
            MaxGruppeStørrelse = maxGruppeStørrelse;
            MaxSider = maxSider;
            ProjektForsvar = projektForsvar;
        }

        public int MaxGruppeStørrelse { get => maxGruppeStørrelse; set => maxGruppeStørrelse = value; }
        public int MaxSider { get => maxSider; set => maxSider = value; }
        public char ProjektForsvar { get => projektForsvar; set => projektForsvar = value; }

        //  retunere det antal ekesamner som der kan være på en dag
        public override int AntalEksamPrDag()
        {
            int value = 0;

            while ((value * Eksaminationstid + 30) < 444)
            {
                value++;
            }

            return value - 1;
        }
    }
}
