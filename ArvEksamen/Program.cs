using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvEksamen
{
    class Program
    {
        static void Main(string[] args)
        {
            MundligEksamen Meksamen = new MundligEksamen('b', true, 10, 20, 20, "Bog");
            Console.WriteLine("Mundlig eksamen: " + Meksamen.AntalEksamPrDag());
            Console.WriteLine("bestået?:" + Meksamen.bedømmelsesform.bestået + ", " + Meksamen.bedømmelsesform.karakter);

            SkriftligEksamen Seksamen = new SkriftligEksamen('a', true, 7, 20, "tavle");
            Console.WriteLine("Skriftlig eksamen:" +Seksamen.AntalEksamPrDag());
            Console.WriteLine("bestået?:" + Seksamen.bedømmelsesform.bestået + ", " + Seksamen.bedømmelsesform.karakter);

            ProjectEksamen Peksamen = new ProjectEksamen('c', true, 11, 20, 3, 15, 'b');
            Console.WriteLine("Project eksamen:"+ Peksamen.AntalEksamPrDag());
            Console.WriteLine("bestået?:" + Peksamen.bedømmelsesform.bestået + ", " + Peksamen.bedømmelsesform.karakter);
        }
    }
}
