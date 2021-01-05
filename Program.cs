using System;

namespace Aprendendo_While
{
    class Program
    {
        static void Main(string[] args)
        {   
            // //While
            // Console.WriteLine("Dígite um número");
            // int numero = int.Parse(Console.ReadLine());

            // int contador = 0;

            // while(contador <= numero){
            //     Console.WriteLine(contador);
            //     contador = contador +1;
            // }

            // //com do while
            // string resposta = "";
            // do{
            //     Console.WriteLine("Você gostaria de repetir?");
            //     resposta = Console.ReadLine();
            // }while(resposta =="Sim");
            // Console.WriteLine("Fim da aplicação");

            // //com for 
            // Console.WriteLine("Digite um valor");
            // int numero = int.Parse(Console.ReadLine());

            // for(var contador = 0; contador <= 5; contador++){
            //     Console.WriteLine(contador);
            // }

            //idade do ator 
            // Console.WriteLine("Digite a idade do ator");
            // int idade = int.Parse(Console.ReadLine());

            // while(idade !=47){
            //     Console.WriteLine("Errou!");
            //     Console.WriteLine("Digite a idade do ator");
            //      idade = int.Parse(Console.ReadLine());
            // }
            // Console.WriteLine("Acertou Miseravi");



            //Exercicio Calculadora
            Console.WriteLine("Digite um número");
            int contador = int.Parse(Console.ReadLine());

            while(contador <=10){
                Console.WriteLine(contador);
                contador = contador *2;  
            }
            
        }
    }
}
