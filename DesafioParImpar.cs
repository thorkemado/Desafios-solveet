using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    class DesafioParImpar
    {

       public void sumaParImpar(int num, out int SumaPar, out int SumaImpar)
        {
            int aux = num - 1;
            if (num == 1)
            {
                SumaImpar = 0;
                SumaPar = 0;
            }
            else
            {
                if (aux % 2 == 0)
                {
                    sumaParImpar(aux, out SumaPar, out SumaImpar);
                    SumaPar += aux;
                }
                else
                {
                    sumaParImpar(aux, out SumaPar, out SumaImpar);
                    SumaImpar += aux;
                }
            }
        }
    }
}
