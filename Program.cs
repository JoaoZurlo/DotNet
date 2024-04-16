using System.Data;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using DOTNET.Modesls;
using Models;

Calculadora calc = new Calculadora();

// calc.Somar(5, 30);
// calc.subtração(10, 50);
// calc.multiplicação(15, 45);
// calc.divisão(2, 2);
// calc.potencia(2, 2);

calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);



































// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else{
//     Console.WriteLine("Vou pedalar um outro dia");
// }




// bool possuiPresencaMinima = true;
// double media = 5;

// if(possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }




// bool ehMaiorDeIdade = false;
// bool possuiAutorizaçãoDoResponsavel = true;

// if (ehMaiorDeIdade || possuiAutorizaçãoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }




// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }


// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("vogal");
// }
// else
// {
//      Console.WriteLine("Não é uma vogal");
// }

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade em compra: {quantidadeCompra}");
// Console.WriteLine($"é possivel realizar a venda? {possivelVenda}");

// if(quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda invalida");
// }


// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada");
// }
// else
// {
//     Console.WriteLine("Desculpa não temos a quantidade desejada em estoque. ");
// }












// int quantidade = 25;
// Console.WriteLine("Valor da variavel quantidade: " + quantidade);

// quantidade = 10;
// Console.WriteLine("Valor da variavel quantidade: " + quantidade);



// double altura = 1.75;
// decimal preço = 1.99M;
// bool condicao = true;



// Console.WriteLine(apresentação);
// Console.WriteLine("Valor da variavel quantidade: " + quantidade);
// Console.WriteLine("Valor da variavel altura: " + altura);
// Console.WriteLine("Valor da variavel preço: " + preço);
// Console.WriteLine("Valor da variavel condição: " + condicao);



// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Joao";
// pessoa1.Idade = 22;
// pessoa1.Apresentar();

// Pessoa pessoa_FisicaRepresentação = new Pessoa();