using System;

using System.Text.RegularExpressions;

namespace REGEX01;
class Program
{
    static void Main(string[] args)
    {
        //Metodo 1: Busqueda de expresion en un texto
        string text = "La casa del casamentero.";
        string exp = "casa";

        MatchCollection encontrados = Regex.Matches(text, exp);

        foreach (Match e in encontrados)
        {
            Console.WriteLine(e);
        }

        Console.WriteLine("----------");

        //Metodo 2: Busqueda de una palabra especifica (ojo si esta al final)
        text = "El estudiante es un casanova en la escuela.";
        exp = " casa ";

        Regex expReg = new Regex(exp);

        encontrados = expReg.Matches(text);

        foreach (Match e in encontrados)
        {
            Console.WriteLine(e);
        }

        Console.WriteLine("----------");

        //El uso del . indica cualquier caracter
        //cabal campeon academico
        text = "Saludos al mas cabal.";
        exp = " ca.";

        MatchesExp(text, exp);

        Console.WriteLine("----------");

        //El uso de [] define los tipos de caracteres que puede contener
        //Nico Necio Naco
        text = "Hola Nico";
        exp = "N[ei]c";

        MatchesExp(text, exp);

        Console.WriteLine("----------");

        //Un rango
        //Nico, Neco, Noco, Ndco, Nzco
        text = "Hola Nico";
        exp = "N[a-u]c";

        MatchesExp(text, exp);

        Console.WriteLine("----------");

        //Complemento. Contempla todas las opciones, excepto las que contengan el simbolo ^
        //Noco Neco
        text = "Hola Nico";
        exp = "N[^ie]c";

        MatchesExp(text, exp);

        Console.WriteLine("----------");

        //Verificamos si el texto contiene la expresion luego de n caracter
        text = "El canal de Nico es mi canal de YouTube";
        exp = "N[ie]c";

        expReg = new Regex(exp);

        if(expReg.IsMatch(text, 5))
        {
            Console.WriteLine("Se encuentra");
        }
        else
        {
            Console.WriteLine("No se encuentra");
        }

        Console.WriteLine("----------");

        //Saber si una cadena finaliza con una expresion
        text = "Esta cadena finaliza con Nico";
        exp = "N[ie]co$";

        MatchesExp(text, exp);

        Console.WriteLine("----------");

        //Elementos opcionales
        text = "Esta es un cadena de prueba Nio";
        exp = "N[ie]c?o"; // => En este caso la letra c puede o no estar en la cadena

        MatchesExp(text, exp);

        Console.WriteLine("----------");

        //Cuantificador: verifica que existan N de esos elementos en la cadena
        text = "Hola Nico 25 jeje";
        exp = "[0-9]{2}"; //=> en este caso verifica que existan, al menos, 2 numeros entre 0 y 9 en la cadena.
        //Tambien funciona con letras. Ej. [a]{2} => esta expresion evaluaria la existencia de, al menos, 2 letras "a" en la cadena

        MatchesExp(text, exp);

        Console.WriteLine("----------");

        //Alternativas
        text = "Yo se programar en C#";
        exp = ("C#|Java|JavaScript"); // => cualquiera de las alternativas es valida

        MatchesExp(text, exp);

        Console.WriteLine("----------");

        //Split: "corta" la cadena en los lugares donde se cumpla la expresion regular
        text = "Este es un texto de prueba";
        exp = " "; // => espacio en blanco

        string[] cadenas = Regex.Split(text, exp);

        foreach (string t in cadenas)
        {
            Console.Write("{0} -> ", t);
        }

        Console.WriteLine("----------");

        //Reemplazar: reemplazamos el texto que coincida con la regex por un texto de nuestra eleccion
        text = "Yo hablo Español y no soy Español";
        expReg = new Regex("Español");

        string reemplazo = "Ingles";

        string resultado = expReg.Replace(text, reemplazo);

        Console.WriteLine(resultado);
    }

    public static void MatchesExp (string text, string exp)
    {
        MatchCollection encontrado = Regex.Matches(text, exp);

        foreach (Match e in encontrado)
        {
            Console.WriteLine(e);
        }

        Console.WriteLine("----------");
    }
}
