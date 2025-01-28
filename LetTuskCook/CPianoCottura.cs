using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetTuskCook
{
    public class CPianoCottura
    {
        int utilizzabile = 1; // 1 - si; 0 - no
        static readonly object _locker = new object();

        public async Task RichiediPiano(CCuoco c) 
        {
            Random rnd = new Random();

            while (true) 
            {
                await Task.Delay(rnd.Next(100, 1000));
                lock (_locker)
                {
                    if (utilizzabile == 1) 
                    {
                        utilizzabile--;
                        return;
                    }
                }
            }
        }

        public async Task PreparaPiatto(CCuoco c) 
        {
            await Task.Delay(c.TempoCottura);
        }

        public async Task RilasciaPiano(CCuoco c)
        {
            Random rnd = new Random();

            while (true) 
            {
                await Task.Delay(rnd.Next(100, 1000));
                lock (_locker)
                {
                    utilizzabile++;
                    return;
                }
            }
        }
    }
}
