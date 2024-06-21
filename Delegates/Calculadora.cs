using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates;

public class Calculadora
{
    public static float Somar(float n1, float n2)
    {
        return n1 + n2;
    }

    public static float Multiplicar(float n1, float n2)
    {
        return n1 * n2; 
    }

    public static float Subtrair(float n1, float n2)
    {
        return n1 - n2; 
    }

    public static float Dividir(float n1, float n2)
    {
        return n1 /  n2;
    }
}
