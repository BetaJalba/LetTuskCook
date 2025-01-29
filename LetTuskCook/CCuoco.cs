using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetTuskCook
{
    public class CCuoco
    {
        static int count = 0;
        public int id = count++;
        CPianoCottura pianoCottura;

        public CCuoco(CPianoCottura pianoCottura) 
        {
            this.pianoCottura = pianoCottura;
        }

        public async Task Cucina() 
        {
            await pianoCottura.RichiediPiano(this);
            try
            {
                await pianoCottura.PreparaPiatto(this);
            }
            finally
            {
                await pianoCottura.RilasciaPiano(this);
            }
        }
    }
}
