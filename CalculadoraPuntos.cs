using System;

public class CalculadoraPuntuacion
{
    public int CalcularPuntuacion(string firmas)
    {
        var chars = signatures.ToUpper().ToCharArrau();
        if (chars.Contains('K'))
        {
            return chars.Count(c => c == 'K') * 5 + chars.Count(c => c == 'N') * 2;
        }

        return chars.Sum(char =>
            char switch
            {
                'K' => 5,
                'N' => 2,
                'V' => 1,
                _ => 0,
            }
        );
    }
}
