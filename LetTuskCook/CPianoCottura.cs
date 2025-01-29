using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetTuskCook
{
    public class CPianoCottura
    {
        static SemaphoreSlim semaforo = new SemaphoreSlim(1, 1);

        public async Task RichiediPiano(CCuoco c) 
        {
            await semaforo.WaitAsync();
            Console.WriteLine($"{c.id} prende il piano");
        }

        public async Task PreparaPiatto(CCuoco c) 
        {
            Console.WriteLine($"{c.id} inizia a cucinare");
            await Task.Delay(1);
            Console.WriteLine($"{c.id} finisce di cucinare");
        }

        public async Task RilasciaPiano(CCuoco c)
        {
            Console.WriteLine($"{c.id} rilascia il piano");
            semaforo.Release();
        }
    }
}
