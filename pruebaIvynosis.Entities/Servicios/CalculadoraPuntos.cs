using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaIvynosis.Entities.Servicios
{
    //Calcular el valor de cada serie de firmas pasadas
    public class CalculadoraPuntos
    {
        public int CalcularPuntuacion(string firmas)
        {
            var chars = firmas.ToUpper().ToCharArray();
            //Si hay una K
            if (chars.Contains('K'))
            {
                return chars.Count(c => c == 'K') * 5 + chars.Count(c => c == 'N') * 2;
            }
            //Si no hay una K
            return chars.Sum(c =>
                c switch
                {
                    'N' => 2,
                    'V' => 1,
                    _ => 0,
                }
            );
        }
    }
}
