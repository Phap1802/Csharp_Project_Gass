using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Qual seu ano de Nascimento? ");

            int anoNS = int.Parse($" {Console.ReadLine()} ");          
           
                //pegando ano atual           
            string ano = DateTime.Now.Year.ToString();
            int anoAT = int.Parse($" {ano} ");

            Console.WriteLine("O Ano atual é : " + anoAT);

            int idade = anoAT - anoNS; 

            Console.WriteLine("Você tem : " + idade);         

            //int idade = idd("{Console.ReadLine()}");

            if (idade >= 0  && idade <= 11 ){

                Crianca();    
                

            }else if (idade >= 12 && idade <= 18 ) {

                Adolecente();

            }else if (idade >= 19 && idade <= 60) {

                
                Adulto();
            
            }else {

                Idoso();

            }



            Console.ReadLine();
           
          

        }

        static void Crianca (){

        Console.WriteLine("Você é uma criança");

        }

        static void Adolecente (){

        Console.WriteLine("Você é uma Adolecente");

        }

        static void Adulto (){

        Console.WriteLine("Você é uma Adulto");

        }

        static void Idoso (){

        Console.WriteLine("Você é uma Idoso");

        }
    }
}
