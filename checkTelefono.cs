using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

public static class Telefono
{

    public static string Check(string[] input)
    {

        foreach(string numero in input)
        {
            if(numero.Length == 13 && numero.StartsWith("+39") || numero.StartsWith("0039"))
            {
                return numero;
            }
            else if(numero.Length == 14 && numero.StartsWith("0039") || numero.StartsWith("+39"))
            {
                return numero;
            }
            else if(numero.Length == 10 && numero.StartsWith("3"))
            {
                return numero;
            }
        }

        return "";
        

    }
}