using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNET.Modesls
{
    public class Pessoa
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string Nome { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos");
        }
        // para pular linha colocar \n 
    
    }
}

//ANOTAÇÕES
//camelCase - ex: pessoaFisica
//PascalCase - ex: PessoaFisica
//Char - unicode character
//bool - true or false
//int -  32 bits -2.147 to 2.147
//long - 64 bits -9.223 to 9.223
//decimal - usado para representar dinheiro 

