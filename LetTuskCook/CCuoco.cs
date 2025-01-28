using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetTuskCook
{
    public class CCuoco
    {
        public int TempoCottura;
        CPianoCottura pianoCottura;

        public CCuoco(CPianoCottura pianoCottura) 
        {
            Random rand = new Random();
            TempoCottura = rand.Next(1000, 3000);
            this.pianoCottura = pianoCottura;
        }

        public async Task Cucina() 
        {
            await pianoCottura.RichiediPiano(this);
            Console.WriteLine("Piano occupato!");
            await pianoCottura.PreparaPiatto(this);
            Console.WriteLine("Cucinato!");
            await pianoCottura.RilasciaPiano(this);
            Console.WriteLine("Piano rilasciato!");
        }
    }
}
