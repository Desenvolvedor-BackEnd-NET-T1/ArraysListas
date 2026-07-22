// o var. exige que a variavel seja declarada e atribuida o codigo abaixo é invalido 
//var arrayNumComVatSemAtribuicao = null;//essa linha vai dar erro de compilação
//já o tipo[] pode ser somente declarado e não atribuido conforme abaixo
//int[] arrayNumSemAtribuicao;


//Posso declarar e usar o var para inferir o tipo da minha variavel;
//var arrayNumComVat = new int[3];

using System.ComponentModel;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

int num1 ;
num1 = 5;
Console.WriteLine ("Uso de variavel simples");
Console.WriteLine (num1);


Console.WriteLine ("Uso de array");
int[] arrayNum = new int[3];

arrayNum[0] = 5;
Console.WriteLine(arrayNum[0]); 
arrayNum[1] = 8;
Console.WriteLine(arrayNum[1]); 
arrayNum[2] = 10;
Console.WriteLine(arrayNum[2]); 


Console.WriteLine ("Uso de arry texto");
string[] arrayText = new string[3];

arrayText[0] = "maça";
arrayText[1] = "banana";
arrayText[2] = "abacaxi";
Console.WriteLine(arrayText[0]); 
Console.WriteLine(arrayText[2]); 
Console.WriteLine(arrayText[1]); 


//Faça um programa que pergunte o tamanho de um array de texto. 
// Crie o array e depois preencha-o utilizando uma estrutura de repetição.
// Após preenchido exiba o array na tela para o usuário


Console.WriteLine("Qual o tamanho do seu array?");
int tamanhoArrary = int.Parse(Console.ReadLine()); 

string[] textos = new string[tamanhoArrary];

for (int i = 0; i < tamanhoArrary; i++)
{
    Console.WriteLine($"digite o {i} nome: ");
    textos[i] = Console.ReadLine();
}


for(int i = 0; i < tamanhoArrary; i++)
{
    Console.WriteLine($"O nome na posicao {i} é {textos[i]}");
}



/// Crie um programa para calculo de média que pegunte quantas notas, obtenha os valores delas,  e  realize  o calculo e depois exiba a nota. 


Console.WriteLine("Quantas notas você deseja calcular a média?");
int quantidadeNotas = int.Parse(Console.ReadLine());

double[] notas = new double[quantidadeNotas];
// solucao mais compreensivel
for (int i = 0; i < quantidadeNotas; i++)
{
    Console.Write("Digite a nota: " + i);
    notas[i] = double.Parse(Console.ReadLine());
}

double soma = 0; 
for (int i = 0; i< quantidadeNotas; i++)
{
    soma += notas[i];    /// soma = soma + notas[i];
}


/// solução mais performatica 
// double soma = 0; 
// for (int i = 0; i < quantidadeNotas; i++)
// {
//     Console.Write("Digite a nota: " + i);
//     notas[i] = double.Parse(Console.ReadLine());
//     soma += notas[i];    
// }



double media = soma / quantidadeNotas; 

Console.WriteLine("a media é de "+ media); 


//Listas  -- Mesma proposta anterior 

Console.WriteLine("Qual o tamanho da sua Lista ?");
int tamanhoLista = int.Parse(Console.ReadLine()); 

List<string> textosLista = new List<string>();

for (int i = 0; i < tamanhoLista; i++)
{
    Console.WriteLine($"digite o {i} nome: ");
    string valorDigitado = Console.ReadLine();
    textosLista.Add(valorDigitado);
}

Console.WriteLine($"Sua lista tem {textosLista.Count} itens ");

for(int i = 0; i < textosLista.Count; i++)
{
    Console.WriteLine($"O nome na posicao {i} é {textosLista[i]}");
}

//foreach 
foreach (string item in textosLista)
{
    Console.WriteLine("o nome é : "+ item);
}

//foreach + interacao 
int interacao = 0; 
foreach (string item in textosLista)
{
    Console.WriteLine($"O nome na posicao {interacao} é {item}");
    interacao++;
}

///
/// Mostrar uso de lista : 


List<int> sequencia = new List<int>(100); 

for (int i = 0;  i< 100; i++ )
{
    sequencia.Add(i);
}

int[] meuArrayNumerico = sequencia.ToArray();
List<int> sequencia2 = meuArrayNumerico.ToList();

sequencia2.AddRange(sequencia);
sequencia.Clear();


Console.WriteLine("dddd");


/// Exercicio de agora receber nomes e preencher na lista ate que o usuario digite sair, quando digitar sair deve mostrar todos os nomes que foram preenchidos
/// 
