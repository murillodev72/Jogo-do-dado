using System;
using CSharpShellCore;
using System.Threading;
namespace Dado{
class Classe{
public static void Main(String[] args){


int numeroAleatorioDoJogador;
int numeroAleatorioDaIa;
int pontosDoJogador = 0;
int pontosDaIa = 0;


Random random = new Random();


for(int i = 0; i<10; i++){
Console.WriteLine("digite algo para jogar o dado ");
Console.ReadLine();

numeroAleatorioDoJogador = random.Next(1,7);

Console.WriteLine("seu número é: "+ numeroAleatorioDoJogador);

Console.WriteLine("...");
System.Threading.Thread.Sleep(1000);

numeroAleatorioDaIa = random.Next(1,7);
Console.WriteLine("o número da ia é: "+ numeroAleatorioDaIa);

if(numeroAleatorioDoJogador > numeroAleatorioDaIa){
pontosDoJogador++;
Console.WriteLine("você ganhou está rodada");

}

else if(numeroAleatorioDaIa > numeroAleatorioDoJogador){
pontosDaIa++;
Console.WriteLine("a IA ganhou esta rodada");
}

else{
Console.WriteLine("empate");
}

Console.WriteLine("placar- jogador: " + pontosDoJogador + " IA: "+ pontosDaIa);
Console.WriteLine();
}

if(pontosDoJogador > pontosDaIa ){
Console.WriteLine("você venceu!");
}
else if(pontosDaIa > pontosDoJogador){
Console.WriteLine("você perdeu!");
}
else{
Console.WriteLine("houve um empate");
}


}
}
}