using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExpressaoRegular03
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex expressao = new Regex(@"^\(?\d{2}\)?[-.\s]?\d{4,5}[-.\s]?\d{4}$");


            Match telefone = expressao.Match("(13)99909-9900");
            if (telefone.Success)
                Console.WriteLine("telefone válido!!!");
            else
                Console.WriteLine("telefone inválido!!!");
            Console.ReadKey();
        }
    }
}





