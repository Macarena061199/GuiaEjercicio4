using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

bool flag = false;

do
{
    Console.Write("Por favor ingrese una frase: ");
    string frase = Console.ReadLine();
    Console.WriteLine("Usted escribió " + frase);
    string fin = "fin";

    Console.WriteLine("¿Quiere seguir escribiendo frases? En caso negativo ingrese 'fin'.");
    string frase2 = Console.ReadLine();
    if (frase2 != fin)
    {
        flag = true;
    }
    else
    {
        Console.WriteLine("Usted escribió " + frase2 + ". En segundos el programa se cerrará.");
        flag = false;
    }
}while(flag ==true);
