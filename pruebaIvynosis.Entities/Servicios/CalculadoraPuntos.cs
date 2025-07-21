using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaIvynosis.Entities.Servicios
{
    internal class CalculadoraPuntos
    {
        public int CalcularPuntuacion(string firmas)
        {
            var chars = firmas.ToUpper().ToCharArray();
            if (chars.Contains('K'))
            {
                return chars.Count(c => c == 'K') * 5 + chars.Count(c => c == 'N') * 2;
            }

            return chars.Sum(c =>
                c switch
                {
                    'K' => 5,
                    'N' => 2,
                    'V' => 1,
                    _ => 0,
                }
            );
        }
    }
}
