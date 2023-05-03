using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("  ");
            Console.WriteLine("Este programa ira calcular o valor para por de combustivel com base no consumo do carro e na distancia da viagem");
            Console.WriteLine("  ");

            // variavel que vai fazer a repetição "while" rodar o programa novamente caso o usuario queira.
            int contador = 1;
            // while para refazer a pesquisa caso o usuario queira.
            while (contador == 1){


            // seleciona o carro a fazer o calculo
            Console.WriteLine("Selecionar com qual carro vai rodar? ");
            Console.WriteLine("  ");

            Console.WriteLine("digite 1 para onix ");
            Console.WriteLine("  ");

            Console.WriteLine("digite 2 para pegeut208 ");
            Console.WriteLine("  ");
            // pega o valor digitado e atribui na variavel int "carro"
            string car = Console.ReadLine();
            int carro = int.Parse(car);


            Console.WriteLine("  ");

            // perguntas quando km vai ser a viagem
            Console.WriteLine("Quantos KM vai rodar?");
            Console.WriteLine("  ");
            // pega o valor digitado e atribui na variavel float "distancia"
            string dist= Console.ReadLine(); 
            float distancia = float.Parse(dist);

            Console.WriteLine("  ");

            // pergunta qual o valor da gasolina atualmente
            Console.WriteLine("Qual Valor do Litro da Gasolina Atualmente ?");
            Console.WriteLine("  ");
            // pega o valor digitado e atribui na variavel float "ValGas"
            string Val1 = Console.ReadLine();
            float ValGas = float.Parse(Val1);

            Console.WriteLine("  ");

            // pergunta qual o valor da Etanol atualmente
            Console.WriteLine("Qual Valor do Litro da Etanol Atualmente ?");
            Console.WriteLine("  ");
            // pega o valor digitado e atribui na variavel float "ValEta"
            string Val2 = Console.ReadLine();
            float ValEta = float.Parse(Val2);

            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");


            //if para executa o calculo de acordo com o carro selecionado 1 ou 2
           
            if (carro==1) { 

                        
                
                // informa o carro selecionado
                Console.WriteLine("Carro selecionado Onix:");
                Console.WriteLine("  ");

                     
                        Console.WriteLine("selecione o tipo da viagem");
                        Console.WriteLine(" ");

                        Console.WriteLine("digite 1 para Cidade ");
                        Console.WriteLine("  ");

                        Console.WriteLine("digite 2 para Estrada ");
                        Console.WriteLine("  ");

                        // tipoViagem1 = pega o que o tipo de viagem que o usuario selecionou
                        string type1 = Console.ReadLine();
                        int tipoViagem1 = int.Parse(type1);

                        Console.WriteLine("  ");   


                        if (tipoViagem1 == 1){
                            
                            //informa o tipo da viagem selecionada !
                            Console.WriteLine("Você Selecionou : Viagem do tipo Cidade!!!");
                            Console.WriteLine("  ");

                            //variaveis do carro 1 consumo de gasolina e etanol na cidade !
                            //c1GasC = carro 1 com fasolina na Cidade.
                            //c1EtaC = carro 1 com etanol na Cidade.
                            float c1GasC = 13.9f;
                            float c1EtaC = 9.9f;   


                            // informa o consumo que o carro 1 faz na cidade "gasolina e etanol"
                            Console.WriteLine($"Onix Faz {c1GasC} Km/L com gasolina ");
                            Console.WriteLine("  ");

                            Console.WriteLine($"Onix Faz {c1EtaC} Km/L com Etanol");
                            Console.WriteLine("  ");

                            
                            // valC1PagGasC = valor Carro1 a pagar em gasolina na  Cidade
                            float valC1PagGasC = (distancia/c1GasC)*ValGas;

                            
                            // valC1PagEtaC = Valor Carro1 a pagar em etanol pela viagem na cidade 
                            float valC1PagEtaC = (distancia/c1EtaC)*ValEta;


                            // informa o valor da viagem na cidade tanto em gasolina tanto em etanol
                            Console.WriteLine($"Sua viagem vai dar: {valC1PagGasC:c} em Gasolina na Cidade !");
                            Console.WriteLine("  ");

                            Console.WriteLine($"Sua viagem vai dar: {valC1PagEtaC:c} em Etanol na Cidade !");
                            Console.WriteLine("  ");

                        }

                        else if (tipoViagem1 == 2){

                            //informa o tipo da viagem selecionada !
                            Console.WriteLine("Você Selecionou : Viagem do tipo Estrada!!!");
                            Console.WriteLine("  ");

                            //variaveis do carro 1 consumo de gasolina e etanol na Estrada !
                            //c1GasE = carro 1 com fasolina na estrada.
                            //c1EtaE = carro 1 com etanol na estrada.
                            float c1GasE = 16.7f;
                            float c1EtaE = 11.7f;   


                            // informa o consumo que o carro 1 faz na Estrada "gasolina e etanol"
                            Console.WriteLine($"Onix Faz {c1GasE} Km/L com gasolina ");
                            Console.WriteLine("  ");

                            Console.WriteLine($"Onix Faz {c1EtaE} Km/L com Etanol");
                            Console.WriteLine("  ");

                            
                            // valC1PagGasE = valor Carro1 a pagar em gasolina na  Estrada
                            float valC1PagGasE = (distancia/c1GasE)*ValGas;

                            
                            // valC1PagEtaE = Valor Carro1a pagar em etanol pela viagem na cidade 
                            float valC1PagEtaE = (distancia/c1EtaE)*ValEta;


                            // informa o valor da viagem na cidade tanto em gasolina tanto em etanol
                            Console.WriteLine($"Sua viagem vai dar: {valC1PagGasE:c} em Gasolina na Estrada !");
                            Console.WriteLine("  ");

                            Console.WriteLine($"Sua viagem vai dar: {valC1PagEtaE:c} em Etanol na Estrada !");
                            Console.WriteLine("  ");



                        } else {

                            Console.WriteLine("Desculpa, Tipo da viagem invalido");
                            Console.WriteLine("");
                            Console.WriteLine("Por favor refaça a pesquisa selecionando alguns dos valores informado no menu.");
                            Console.WriteLine("");                     



                        }




                                  

                
                
            }
            else if (carro==2){
                
                // informa o carro selecionado
                Console.WriteLine("Carro selecionado Pegeut208:");
                Console.WriteLine("  ");


   

                        Console.WriteLine("selecione o tipo da viagem");
                        Console.WriteLine(" ");

                        Console.WriteLine("digite 1 para Cidade ");
                        Console.WriteLine("  ");

                        Console.WriteLine("digite 2 para Estrada ");
                        Console.WriteLine("  ");

                        // tipoViagem2 = pega o que o tipo de viagem que o usuario selecionou
                        string type2 = Console.ReadLine();
                        int tipoViagem2 = int.Parse(type2);

                        Console.WriteLine("  ");   


                        if (tipoViagem2 == 1){
                            
                            //informa o tipo da viagem selecionada !
                            Console.WriteLine("Você Selecionou : Viagem do tipo Cidade!!!");
                            Console.WriteLine("  ");

                            //variaveis do carro 2 consumo de gasolina e etanol na cidade !
                            //c2GasC = carro 2 com fasolina na Cidade.
                            //c2EtaC = carro 2 com etanol na Cidade.
                            float c2GasC = 10.9f;
                            float c2EtaC = 7.5f;   


                            // informa o consumo que o carro 2 faz na cidade "gasolina e etanol"
                            Console.WriteLine($"Peugeot 208 Faz {c2GasC} Km/L com gasolina ");
                            Console.WriteLine("  ");

                            Console.WriteLine($"Peugeot 208 Faz {c2EtaC} Km/L com Etanol");
                            Console.WriteLine("  ");

                            
                            // valC2PagGasC = valor Carro2 a pagar em gasolina na  Cidade
                            float valC2PagGasC = (distancia/c2GasC)*ValGas;

                            
                            // valC2PagEtaC = Valor Carro2 a pagar em etanol pela viagem na cidade 
                            float valC2PagEtaC = (distancia/c2EtaC)*ValEta;


                            // informa o valor da viagem na cidade tanto em gasolina tanto em etanol
                            Console.WriteLine($"Sua viagem vai dar: {valC2PagGasC:c} em Gasolina na Cidade !");
                            Console.WriteLine("  ");

                            Console.WriteLine($"Sua viagem vai dar: {valC2PagEtaC:c} em Etanol na Cidade !");
                            Console.WriteLine("  ");

                        }

                        else if (tipoViagem2 == 2){

                            //informa o tipo da viagem selecionada !
                            Console.WriteLine("Você Selecionou : Viagem do tipo Estrada!!!");
                            Console.WriteLine("  ");

                            //variaveis do carro 2 consumo de gasolina e etanol na Estrada !
                            //c2GasE = carro 2 com fasolina na estrada.
                            //c2EtaE = carro 2 com etanol na estrada.
                            float c2GasE = 13.1f;
                            float c2EtaE = 9.0f;   


                            // informa o consumo que o carro 2 faz na Estrada "gasolina e etanol"
                            Console.WriteLine($"Peugeot 208 Faz {c2GasE} Km/L com gasolina ");
                            Console.WriteLine("  ");

                            Console.WriteLine($"Peugeot 208 Faz {c2EtaE} Km/L com Etanol");
                            Console.WriteLine("  ");

                            
                            // valC2PagGasE = valor Carro2 a pagar em gasolina na  Estrada
                            float valC2PagGasE = (distancia/c2GasE)*ValGas;

                            
                            // valC2PagEtaE = Valor Carro1a pagar em etanol pela viagem na Estrada 
                            float valC2PagEtaE = (distancia/c2EtaE)*ValEta;


                            // informa o valor da viagem na cidade tanto em gasolina tanto em etanol
                            Console.WriteLine($"Sua viagem vai dar: {valC2PagGasE:c} em Gasolina na Estrada !");
                            Console.WriteLine("  ");

                            Console.WriteLine($"Sua viagem vai dar: {valC2PagEtaE:c} em Etanol na Estrada !");
                            Console.WriteLine("  ");



                        } else {

                            Console.WriteLine("Desculpa, Tipo da viagem invalido");
                            Console.WriteLine("");
                            Console.WriteLine("Por favor refaça a pesquisa selecionando alguns dos valores informado no menu.");
                            Console.WriteLine("");                     



                        }


               
                





            } else {

                Console.WriteLine("Carro selecionado nao identificado");
                Console.WriteLine("  ");

                Console.WriteLine("reinicie o programa, selecione 1 ou 2 de acordo com o carro desejado!");
                Console.WriteLine("  ");

                Console.WriteLine("obrigado pela compreensão !");
                Console.WriteLine("  ");
            }

            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");

            Console.WriteLine("Precione Tecla Enter Para Continuar ...");
            Console.ReadLine();

            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");


            // pergunta se vai continua a pesquisa
            Console.WriteLine ( "Deseja fazer outra pesquisa ? ");
            Console.WriteLine("  ");
            Console.WriteLine("digite 1 para: Sim, Desejo fazer outra pesquisa! ");
            Console.WriteLine("  ");
            Console.WriteLine("digite 0 para: Não ! finalizar programa! ");
            Console.WriteLine("  ");
            // captura a resposta e converte para variavel do tipo inteiro
            string ref1 = Console.ReadLine();
            int refazer = int.Parse(ref1);


            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");


            // estrutura condicional "if" que vai continua ou para a estrutura de repetição " while "
            if (refazer == 1) {

                contador = 1;

                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("--------------------------------------");

            } else {

                Console.WriteLine("  ");
                Console.WriteLine("Obrigado por usar o meu programa!");
                Console.WriteLine("  ");
                Console.WriteLine("Até a Proxima pesquisa de Preço.");      

                contador = 0;

            }
            


            }

        }
    }
}